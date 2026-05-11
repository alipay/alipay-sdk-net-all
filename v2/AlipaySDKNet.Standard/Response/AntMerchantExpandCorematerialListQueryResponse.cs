using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandCorematerialListQueryResponse.
    /// </summary>
    public class AntMerchantExpandCorematerialListQueryResponse : AopResponse
    {
        /// <summary>
        /// 核心原材料详细信息
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("supplier_core_material_info")]
        public List<SupplierCoreMaterialInfo> DataList { get; set; }
    }
}
