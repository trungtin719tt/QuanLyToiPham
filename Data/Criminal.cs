//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Criminal
    {
        public long Id { get; set; }
        public long ProfileID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string CommitedDate { get; set; }
    
        public virtual Profile Profile { get; set; }
    }
}
