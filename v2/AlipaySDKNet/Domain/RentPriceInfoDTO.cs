using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPriceInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPriceInfoDTO : AopObject
    {
        /// <summary>
        /// 商家优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("discounted_price")]
        public string DiscountedPrice { get; set; }

        /// <summary>
        /// 订单总价，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("order_price")]
        public string OrderPrice { get; set; }
    }
}
