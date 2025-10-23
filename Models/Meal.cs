namespace _2025_10_23.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public int Typeid { get; set; }
        public string Name { get; set; }
        public string Pic { get; set; }

        public Meal(int id, int typeid, string name, string pic)
        {
            this.Id = id;
            this.Typeid = typeid;
            this.Name = name;
            this.Pic = pic;
        }
    }
}