namespace BisleriumCafe.Data.Models
{

    //Memberships
    public class Membership : IModel, ICloneable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public string Email { get; set; }
        public int DaysPurchased { get; set; }
        public string PhoneNumber { get; set; }
        public bool ThisDrinkFree { get; set; } = false;
        public bool GetsDiscount { get; set; } = false;
        public int DiscountPercent { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Guid CreatedBy { get; set; }

        public object Clone()
        {
            return new Membership
            {
                Id = Id,
                FullName = FullName,
                Email = Email,
                PhoneNumber = PhoneNumber,
                ThisDrinkFree = ThisDrinkFree,
                GetsDiscount = GetsDiscount,
                DiscountPercent = DiscountPercent,
                CreatedAt = CreatedAt,
                CreatedBy = CreatedBy,
            };
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}