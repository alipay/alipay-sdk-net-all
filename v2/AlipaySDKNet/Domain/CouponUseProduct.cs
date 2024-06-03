using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CouponUseProduct Data Structure.
    /// </summary>
    [Serializable]
    public class CouponUseProduct : AopObject
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("commodity_code")]
        public string CommodityCode { get; set; }

        /// <summary>
        /// 资源包规格编码
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }
    }
}
