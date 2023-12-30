namespace Interface_x_AbstractClass.Abstract_Class
{
    public abstract class Payment
    {
        public DateTime ExpirationDate { get; set; }
        public double Price { get; set; }
        public string PaymentResult {  get; set; } = string.Empty;
        public virtual void Pay()
        {
            PaymentResult = "Paid";
        }
    }
}