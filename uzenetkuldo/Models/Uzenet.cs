using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace uzenetkuldo.Models
{
    public class Uzenet : Tablazat
    {
        [DataMember]
        public string Szoveg { get; set; }

        [DataMember]
        public DateTime KüldesiIdo { get; set; }

        [DataMember]
        public string UzenetTipus { get; set; }

        [DataMember]
        public string Telefon { get; set; }

        [DataMember]
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} Szöveg{Szoveg} Küldési idő: {KüldesiIdo} Üzenet típus: {UzenetTipus}, Telefon: {Telefon} Email: {Email}";
        }
    }
}