using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoyaltyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RoyaltyDTO : AopObject
    {
        /// <summary>
        /// 租金分账期数，举例1、2、3.....
        /// </summary>
        [XmlElement("royalty_period")]
        public long RoyaltyPeriod { get; set; }

        /// <summary>
        /// 分账金额，举例50.00  单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("royalty_price")]
        public string RoyaltyPrice { get; set; }

        /// <summary>
        /// 分账金类型，目前仅支持： RENT(租金分账)、BUYOUT(买断分账)
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }
    }
}
