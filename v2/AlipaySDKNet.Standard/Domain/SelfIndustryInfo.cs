using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SelfIndustryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SelfIndustryInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("oil_product_list")]
        [XmlArrayItem("oil_product_info")]
        public List<OilProductInfo> OilProductList { get; set; }
    }
}
