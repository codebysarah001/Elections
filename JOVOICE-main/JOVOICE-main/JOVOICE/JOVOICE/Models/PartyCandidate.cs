//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JOVOICE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartyCandidate
    {
        public long id { get; set; }
        public string partyname { get; set; }
        public string electionarea { get; set; }
        public string email { get; set; }
        public Nullable<long> national_id { get; set; }
        public string gender { get; set; }
        public string birthdate { get; set; }
        public string religion { get; set; }
        public Nullable<long> ordercandidate { get; set; }
        public Nullable<long> fk_counter { get; set; }
        public string candidatename { get; set; }
        public string city { get; set; }
    }
}