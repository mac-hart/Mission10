using System.ComponentModel.DataAnnotations;

namespace Mission10API.Data
{
    public class Bowlers
    {
        [Key]
        //BowlerName needs to be a concatenation of BowlerFirstName and BowlerLastName in the Bowlers table
        public string BowlerFirstName { get; set; }

        public string BowlerLastName { get; set; }

        public string BowlerName => $"{BowlerFirstName} {BowlerLastName}";

        // team name is in "Teams" table
        //public string TeamName { get; set; }    

        public string BowlerCity { get; set; }

        public string BowlerState { get; set; }

        public int BowlerZip {  get; set; }

        public string BowlerPhoneNumber { get; set; }

        public string BowlerAddress { get; set; }
        public int TeamId { get; set; } 
        public Team Team { get; set; }
    }

    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        public string TeamName { get; set; }

    }
}
