//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationData.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public int ScheduleId { get; set; }
        public int PersonId { get; set; }
        public int CourseId { get; set; }
        public bool Active { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Person Person { get; set; }
    }
}
