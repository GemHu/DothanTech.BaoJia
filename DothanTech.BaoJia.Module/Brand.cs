//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DothanTech.BaoJia.Module
{
    using System;
    using System.Collections.Generic;
    
    public partial class Brand
    {
        public Brand()
        {
            this.ProductModule = new HashSet<ProductModule>();
        }
    
        public int Id { get; set; }
        public string BrandName { get; set; }
        public int RecommandType { get; set; }
        public float Value { get; set; }
    
        public virtual ICollection<ProductModule> ProductModule { get; set; }
        public virtual RecommandTable RecommandTable { get; set; }
    }
}
