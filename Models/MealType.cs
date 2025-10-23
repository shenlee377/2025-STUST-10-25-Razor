namespace _2025_10_23.Models
{
    public class MealType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MealType(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}