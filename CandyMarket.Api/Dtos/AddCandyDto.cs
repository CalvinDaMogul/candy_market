namespace CandyMarket.Api.Dtos
{
    public class AddCandyDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public int BillingActive { get; set; }
        public int HasSSo { get; set; }
        public int Has2Fa { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
    }
}