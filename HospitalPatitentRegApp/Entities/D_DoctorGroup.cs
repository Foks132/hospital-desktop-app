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
    
    public partial class D_DoctorGroup
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public Nullable<bool> isDoctorChief { get; set; }
    
        public virtual D_Doctor D_Doctor { get; set; }
        public virtual D_ReceptionSchedule D_ReceptionSchedule { get; set; }
    }
}
