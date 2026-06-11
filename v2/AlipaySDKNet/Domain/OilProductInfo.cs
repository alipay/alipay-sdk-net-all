using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OilProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OilProductInfo : AopObject
    {
        /// <summary>
        /// 如果门店有营销活动，则返回门店油品的优惠价格，单位元，精度小数点两位
        /// </summary>
        [XmlElement("discount_price")]
        public string DiscountPrice { get; set; }

        /// <summary>
        /// 门店维护的油品价格，单位元，精度小数点两位
        /// </summary>
        [XmlElement("listed_price")]
        public string ListedPrice { get; set; }

        /// <summary>
        /// 油品类型code
        /// </summary>
        [XmlElement("oil_type")]
        public string OilType { get; set; }
    }
}
