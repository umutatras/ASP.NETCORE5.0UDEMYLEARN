namespace UAUdemy.BankApp.Web.Data.Entities
{
    public class Account
    {
        public int id { get; set; }
        public decimal Balance { get; set; }
        public int AccountNumber { get; set; }
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
