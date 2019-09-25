using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffordableHousingDesktopApp
{
    class APIDataObject
    {
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string Quality { get; set; }

        public APIDataObject(string city, string state, string county, string quality) {
            this.City = city;
            this.State = state;
            this.County = county;
            this.Quality = quality;
        }
    }
}
