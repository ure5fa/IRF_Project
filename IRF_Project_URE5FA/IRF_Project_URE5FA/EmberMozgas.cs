//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IRF_Project_URE5FA
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmberMozgas
    {
        public int EmberMozgasId { get; set; }
        public Nullable<int> EmberFK { get; set; }
        public Nullable<int> MozgasFK { get; set; }
    
        public virtual Ember Ember { get; set; }
        public virtual Mozgas Mozgas { get; set; }
    }
}