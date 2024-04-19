using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PriceInfoModifyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PriceInfoModifyDTO : AopObject
    {
        /// <summary>
        /// 订单金额，单位：元
        /// </summary>
        [XmlElement("order_price")]
        public string OrderPrice { get; set; }
    }
}
