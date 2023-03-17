namespace Core.Entities
{
    public class Year
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
