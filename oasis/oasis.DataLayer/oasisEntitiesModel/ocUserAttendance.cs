//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace oasis.DataLayer.oasisEntitiesModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ocUserAttendance
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public System.DateTime AttendanceDate { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> BloodPressure { get; set; }
        public string ComplainDesc { get; set; }
    }
}
