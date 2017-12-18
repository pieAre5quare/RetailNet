using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Services.RqApiService
{
    public class RqApiStore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public List<Role> Roles { get; set; } = new List<Role>() { new Role() { Name = "Location" } };
        public DateTime CreatedUtc { get; set; }
        public DateTime LastModifiedUtc { get; set; }
        public Address Address { get; set; }
        public string ClientEntityId { get; set; }
        public List<Contact> Contacts { get; set; }
        public Geography Geography { get; set; }
        public List<object> Relationships { get; set; }
        public string SortName { get; set; }
        public StoreHours StoreHours { get; set; }
        public List<StorePhoneNumber> StorePhoneNumbers { get; set; }
        public TimeZone TimeZone { get; set; }
        public int Version { get; set; }
    }

    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Zip { get; set; }
    }


    public class PhoneNumber
    {
        public string Description { get; set; }
        public string Number { get; set; }
        public string Extension { get; set; }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
    }

    public class Geography
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }

    public class Open
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
    }

    public class Close
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
    }

    public class Monday
    {
        public Open Open { get; set; }
        public Close Close { get; set; }
    }



    public class Tuesday
    {
        public Open Open { get; set; }
        public Close Close { get; set; }
    }



    public class Wednesday
    {
        public Open Open { get; set; }
        public Close Close { get; set; }
    }


    public class Thursday
    {
        public Open Open { get; set; }
        public Close Close { get; set; }
    }


    public class Friday
    {
        public Open Open { get; set; }
        public Close Close { get; set; }
    }



    public class Saturday
    {
        public Open Open { get; set; }
        public Close Close { get; set; }
    }



    public class Sunday
    {
        public Open Open { get; set; }
        public Close Close { get; set; }
    }

    public class StoreHours
    {
        public Monday Monday { get; set; }
        public Tuesday Tuesday { get; set; }
        public Wednesday Wednesday { get; set; }
        public Thursday Thursday { get; set; }
        public Friday Friday { get; set; }
        public Saturday Saturday { get; set; }
        public Sunday Sunday { get; set; }
    }

    public class StorePhoneNumber
    {
        public string Description { get; set; }
        public string Number { get; set; }
        public string Extension { get; set; }
    }

    public class TimeZone
    {
        public string Id { get; set; }
        public bool DaylightSavingTimeEnabled { get; set; }
    }

}
