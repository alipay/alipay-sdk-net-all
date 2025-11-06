using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleDeliveryPriceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleDeliveryPriceDTO : AopObject
    {
        /// <summary>
        /// 履约价格（单位为元，金额超过1000就不允许小数点）
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
