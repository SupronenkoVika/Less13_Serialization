namespace Less13_Serialization
{
    [Serializable]
    public class Squad
    {
        public string SquadName { get; set; }
        public string HomeTown { get; set; }
        public int Formed { get; set; }
        public string SecretBase { get; set; }
        public bool Active { get; set; }
        public List<Members> Members { get; set; }
    }
}
