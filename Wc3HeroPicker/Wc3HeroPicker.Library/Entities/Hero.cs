namespace Wc3HeroPicker.Library.Entities
{
    public class Hero
    {
        public string Id   { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}