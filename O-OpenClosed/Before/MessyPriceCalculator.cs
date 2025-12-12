using System;

namespace SOLID_By_Example.O_OpenClosed.Before
{
    public class MessyPriceCalculator
    {
        public decimal Calculate(decimal price, string discountType)
        {
            if (discountType == "None")
            {
                return price;
            }
            else if (discountType == "percentage")
            {
                return price * 0.9m; // 10% discount 
            }
            else if (discountType == "fixed_value")
            {
                return price - 20m;
            }
            else if (discountType == "Black_Friday_Coupon")
            {
                return price * 0.7m; //30% off
            }

            // Example: In the future...
            // else if (discountType == "loyalty_discount") ...
            // else if (discountType == "new_type_x_discount") ...

            throw new Exception("Invalid discount type.");
        }
    }
}