namespace Less13_Serialization
{
    [Serializable]
    public class Members
    {
        public string Name { get; set; }
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age must be positive");
                    _age = value;
                }
            }
        }
        public string SecretIdentity { get; set; }
        public List<string> Powers { get; set; }
    }
}