//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrSavviAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            this.Consultations = new HashSet<Consultation>();
            this.Consultation_Procedure = new HashSet<Consultation_Procedure>();
        }
    
        public int Appointment_ID { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public int Patient_ID { get; set; }
        public int Timeslot_ID { get; set; }
        public string AppointmentDescription { get; set; }
        public string ThemeColor { get; set; }
        public Nullable<bool> IsFullDay { get; set; }
        public string AppointmentStatus { get; set; }
    
        public virtual Timeslot Timeslot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultation> Consultations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultation_Procedure> Consultation_Procedure { get; set; }
        public virtual Patient Patient { get; set; }
    }
}