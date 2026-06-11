using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryInfo : AopObject
    {
        /// <summary>
        /// 门店油品信息列表
        /// </summary>
        [XmlArray("oil_product_list")]
        [XmlArrayItem("oil_product_info")]
        public List<OilProductInfo> OilProductList { get; set; }
    }
}
