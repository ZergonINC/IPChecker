﻿namespace IPChecker.Interfaces
{
    internal interface IBaseModel
    {
        string IP { get; set; }

        string MyIP { get; set; }

        string Country { get; set; }

        string Region { get; set; }

        string City { get; set; }

        string Currency { get; set; }
    }
}
