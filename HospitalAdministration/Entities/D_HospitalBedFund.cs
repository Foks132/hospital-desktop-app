//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalAdministration.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class D_HospitalBedFund
    {
        public int Room { get; set; }
        public int Bed { get; set; }
        public Nullable<int> PatientId { get; set; }
    
        public virtual D_Patient D_Patient { get; set; }
    }
}
