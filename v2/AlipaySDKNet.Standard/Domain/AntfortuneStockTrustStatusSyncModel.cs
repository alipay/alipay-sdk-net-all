using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockTrustStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockTrustStatusSyncModel : AopObject
    {
        /// <summary>
        /// 信托产品发行代码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// ON表示在售，OFF表示售罄或下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
