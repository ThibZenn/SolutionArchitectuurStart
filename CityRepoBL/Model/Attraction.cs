using CityRepoBL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityRepoBL.Model
{
    public class Attraction
    {
        public Attraction(string name, string description, string type, string location, string organizer)
        {
            Name = name;
            Description = description;
            Type = type;
            Location = location;
            Organizer = organizer;
        }
        public Attraction(int iD, string name, string description, string type, string location, string organizer)
        {
            Id = iD;
            Name = name;
            Description = description;
            Type = type;
            Location = location;
            Organizer = organizer;
        }

        public int? Id { get; set; } //id is nullable omdat de id aangemaakt wordt in de DB (dus de id wordt pas later aangemaakt)
        private string name = "";
        public string Name
        {
            get { return name; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new CityException("name invalid"); name = value; }
        }
        public string Description { get; set; }
        public string Type { get; set; }
        private string location;
        public string Location
        {
            get { return location; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new CityException("location invalid"); location = value; }
        }
        private string organizer;
        public string Organizer
        {
            get { return organizer; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new CityException("organizer invalid"); organizer = value; }
        }
        public string ShowShortDescription()
        {
            return $"{Name} is of type {Type} and located at {Location}";
        }
        public string ShowFullDescription()
        {
            return $"{Name} is of type {Type}, organized by {Organizer} and located at {Location}"
                + $"\nDetails : {Description}";
        }
        public override bool Equals(object? other) // deze methode overschrijven we omdat we de .contains methode gebruiken in city. Dit moet altijd gebeuren als we .contains gebruiken met een object!
        {
            if (other is Attraction) // kijken of het type van het object juist is
            {
                Attraction compAttraction = (Attraction)other; 
                if (Id.HasValue && compAttraction.Id.HasValue) // id's controlleren, zijn ze gelijk return true
                {
                    if (Id == compAttraction.Id) return true; else return false;
                }
                else // Als ze alletwee nog geen id hebben, dan gaan we proberen vergelijken op naam en organizer om toch nog te kunnen weten of ze gelijk zijn. Deze regel moeten we toevoegen omdat we aangegeven hebben bij de ID dat die nullable mag zijn.
                {
                    return Name == compAttraction.Name &&
                   Organizer == compAttraction.Organizer;
                }
            }
            else { return false; }
        }
    }
}
