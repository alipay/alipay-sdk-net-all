using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantBrandListResult Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantBrandListResult : AopObject
    {
        /// <summary>
        /// 商户已有品牌
        /// </summary>
        [XmlArray("brand_list_result")]
        [XmlArrayItem("brand_result")]
        public List<BrandResult> BrandListResult { get; set; }
    }
}
