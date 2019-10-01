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
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Appointments = new HashSet<Appointment>();
            this.Consultations = new HashSet<Consultation>();
            this.Patient1 = new HashSet<Patient>();
            this.Patient_Allergy_List = new HashSet<Patient_Allergy_List>();
            this.Prescription_Line = new HashSet<Prescription_Line>();
            this.Xrays = new HashSet<Xray>();
        }
    
        public int Patient_ID { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string PatientCell { get; set; }
        public string PatientWorkNum { get; set; }
        public string PatientTelNum { get; set; }
        public string PatientEmail { get; set; }
        public string PatientPoBox { get; set; }
        public string PatientHomeAddress { get; set; }
        public string PatientIDNum { get; set; }
        public string PatientPassportNum { get; set; }
        public string MedicalAidNo { get; set; }
        public Nullable<int> DependentNo { get; set; }
        public Nullable<int> Scheme_ID { get; set; }
        public Nullable<int> Title_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultation> Consultations { get; set; }
        public virtual Medical_Aid_Scheme Medical_Aid_Scheme { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patient1 { get; set; }
        public virtual Patient Patient2 { get; set; }
        public virtual Title Title { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient_Allergy_List> Patient_Allergy_List { get; set; }
        public virtual Patient Patient11 { get; set; }
        public virtual Patient Patient3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prescription_Line> Prescription_Line { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Xray> Xrays { get; set; }
    }
}
