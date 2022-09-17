namespace IPChecker.Interfaces
{
    internal interface IBaseModel
    {
        public int Id { get; set; }

        public string Ip { get; set; }

        public string Country_rus { get; set; }

        public string Region_rus { get; set; }

        public string City_rus { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }
}
