using Interface_x_AbstractClass.Abstract_Class;
using Interface_x_AbstractClass.Interfaces;
namespace Interface_x_AbstractClass.PaymentMethods
{
    public class PaymentViaCard : Payment, IPayment
    {
        public DateTime ExpirationDate { get; set; } //It is not required to declare fields that were declared in the abstract class. 

        public override void Pay() // Abstract Classes can have their virtual methods overwritten
        {
            PaymentResult = "Not Accepted";
        }
        public bool IsPaid() // All signature methods in the Interface are required to be implemented
        {
            bool isPaymentSuccessful = PaymentResult != "Not Accepted";
            return isPaymentSuccessful;
        }
    }
}
