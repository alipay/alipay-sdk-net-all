using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandCorematerialRelationUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandCorematerialRelationUploadModel : AopObject
    {
        /// <summary>
        /// 供应商关联信息，如关联核心原材料等信息
        /// </summary>
        [XmlArray("supplier_rel_list")]
        [XmlArrayItem("supplier_rel_data")]
        public List<SupplierRelData> SupplierRelList { get; set; }
    }
}
