//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalPatitentRegApp.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class D_DoctorWorkSchedule_History
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> TimeBeginDay { get; set; }
        public Nullable<System.TimeSpan> TimeEndDay { get; set; }
        public Nullable<bool> isWorked { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public System.DateTime DateChange { get; set; }
        public System.TimeSpan TimeChange { get; set; }
        public Nullable<int> TypeChange { get; set; }
    
        public virtual D_ChangeType D_ChangeType { get; set; }
        public virtual D_Doctor D_Doctor { get; set; }
    }
}
