//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Framework.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerInfo
    {
        public override int ID { get; set; }
        public override System.Guid Key { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public override int ActivityID { get; set; }
        public override System.DateTime CreatedDate { get; set; }
        public override System.DateTime ModifiedDate { get; set; }
        public System.Guid CustomerTypeKey { get; set; }
    }
}
namespace Framework.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerType
    {
        public override int ID { get; set; }
        public override System.Guid Key { get; set; }
        public string Name { get; set; }
        public override System.DateTime CreatedDate { get; set; }
        public override System.DateTime ModifiedDate { get; set; }
    }
}
