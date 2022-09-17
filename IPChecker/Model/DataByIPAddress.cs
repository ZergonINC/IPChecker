using IPChecker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPChecker.Model
{
    // Класс для десериализации данных и их хранения в базе данных.

    public class DataByIPAddress : IBaseModel
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
