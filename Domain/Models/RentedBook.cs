namespace Domain.Models
{
    public class RentedBook
    {
        public Guid RentalId { get; set; }
        public Guid BookId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime BookCreatedAt { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime RentalCreatedAt { get; set; }
    }
}
