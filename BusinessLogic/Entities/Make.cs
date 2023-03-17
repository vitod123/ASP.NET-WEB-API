namespace Core.Entities
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }     // Название производителя
        public string Country { get; set; }  // Страна производителя
        public ICollection<Car> Cars { get; set; }
    }
}
