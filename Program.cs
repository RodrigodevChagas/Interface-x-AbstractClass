using Interface_x_AbstractClass.Abstract_Class;
using Interface_x_AbstractClass.Interfaces;
using Interface_x_AbstractClass.PaymentMethods;


//Interfaces and AbstractClass cannot be instantiated
    //IPayment paymentInterface = new (); // <- if uncommented, an error will be generated
    //Payment paymentAbstractClass = new (); // <- if uncommented, an error will be generated

PaymentViaCard paymentViaCard = new () 
{
    ExpirationDate = DateTime.Now,
    PaymentResult = "Paid",
    Price = 100
};

Console.WriteLine(paymentViaCard.IsPaid()); // abstract class' method is being call to check payment status (set as "Paid")

paymentViaCard.Pay(); // interface's method is called so it will set the payment status to "Not Accepeted"

Console.WriteLine(paymentViaCard.IsPaid()); // abstract class' method is being call to check payment status (now set as "Not Accepeted")

Console.ReadLine();