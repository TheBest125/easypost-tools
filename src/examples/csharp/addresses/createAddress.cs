﻿using System;
using System.Collections.Generic;
using EasyPost;
using Newtonsoft.Json;

namespace csharp
{
    class createAddress
    {
        static void Main()
        {
            EasyPost.ClientManager.SetCurrent(Environment.GetEnvironmentVariable("EASYPOST_TEST_API_KEY"));

            Address address = Address.Create(
                new Dictionary<string, object>() {
                    { "street1", "417 MONTGOMERY ST" },
                    { "street2", "FLOOR 5" },
                    { "city", "SAN FRANCISCO" },
                    { "state", "CA" },
                    { "zip", "94104" },
                    { "country", "US" },
                    { "company", "EasyPost" },
                    { "phone", "415-123-4567" }
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
        }
    }
}
