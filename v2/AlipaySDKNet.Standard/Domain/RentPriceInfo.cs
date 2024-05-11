using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentPriceInfo : AopObject
    {
        /// <summary>
        /// 附加金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("additional_price")]
        public string AdditionalPrice { get; set; }

        /// <summary>
        /// 优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("discounted_price")]
        public string DiscountedPrice { get; set; }

        /// <summary>
        /// 运费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("freight")]
        public string Freight { get; set; }

        /// <summary>
        /// 订单金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("order_price")]
        public string OrderPrice { get; set; }
    }
}
