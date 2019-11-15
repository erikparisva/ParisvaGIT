namespace HeroProject
{
    class Hero
    {
        private string _name;
        private string _location;

        public string Name { get => _name; set => _name = value; }
        public string Location { get => _location; set => _location = value; }

        public Hero(string name, string location)
        {
            _name = name;
            Location = location;
        }
        public int rescue(int inDanger)
        {
            return (int)(inDanger * 0.95);
        }
        public override string ToString()
        {
            return $"Hero {_name} keeps the peace in {_location}.";
        }
    }
}
