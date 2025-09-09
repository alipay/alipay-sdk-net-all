using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShippingTimeLimitVO Data Structure.
    /// </summary>
    [Serializable]
    public class ShippingTimeLimitVO : AopObject
    {
        /// <summary>
        /// 物流发货时效
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }
    }
}
