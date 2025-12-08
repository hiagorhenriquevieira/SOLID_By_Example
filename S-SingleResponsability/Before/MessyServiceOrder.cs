using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace SOLID_By_Example.S_SingleResponsability.Before
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public decimal Total { get; set; }
    }

    public class Item
    {
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }

    public static class EmailSender
    {
        public static void Send(string to, string subject, string body)
        {
            Console.WriteLine($"[EMAIL] To: {to} | Subject: {subject} | Body: {body}");
        }
    }

    public class MessyServiceOrder
    {
        // Hardcoded
        private string _connectionString = "Server=.;Database=MyDataBase;Trusted_Connection=True;";

        public void OrderProcess(Order order)
        {
            // ➤ 1) Validation (first responsibility).
            if (order == null)
                throw new Exception("Null order.");

            if (string.IsNullOrWhiteSpace(order.Customer))
                throw new Exception("invalid customer.");

            if (order.Items == null || !order.Items.Any())
                throw new Exception("Order without items.");

            // ➤ 2) Price calculation (second responsibility).
            order.Total = 0;
            foreach (var item in order.Items)
                order.Total += item.Price * item.Amount;

            // ➤ 3) Logging (third responsibility)
            Console.WriteLine($"[LOG] Processing order {order.Id} | Customer: {order.Customer} | Total: {order.Total}");

            // ➤ 4) Persistence in the database (fourth responsibility).
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = $"INSERT INTO Orders (Id, Customer, Total) VALUES ({order.Id}, '{order.Customer}', {order.Total})";
                        cmd.ExecuteNonQuery();
                    }

                    foreach (var item in order.Items)
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = $"INSERT INTO OrdersItems (IdOrder, Amount, Price) VALUES ({order.Id}, {item.Amount}, {item.Price})";
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR] Error saving to database.: " + ex.Message);
                throw;
            }

            // ➤ 5) Generate invoice from file (fifth responsibility).
            try
            {
                Directory.CreateDirectory("Notes");

                var invoicePath = Path.Combine("Notes", $"InvoicePath_{order.Id}.txt");

                File.WriteAllText(invoicePath,
                    $"Invoice - Order {order.Id}\nCustomer: {order.Customer}\nTotal: {order.Total}");

                Console.WriteLine($"Generated note: {invoicePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[WARN] Failed to generate invoice: " + ex.Message);
            }

            // ➤ 6) Send email (sixth responsibility).
            try
            {
                EmailSender.Send("customer@exemple.com",
                    $"Order Confirmation {order.Id}",
                    $"Your order has been successfully processed. Total: {order.Total}");
            }
            catch
            {
                Console.WriteLine("[WARN] Failed to send email");
            }

            // ➤ 7) Completion (seventh responsibility).
            Console.WriteLine("Processing complete.");
        }
    }
}