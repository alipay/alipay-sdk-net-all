using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopRating Data Structure.
    /// </summary>
    [Serializable]
    public class ShopRating : AopObject
    {
        /// <summary>
        /// 店铺评分下限,必须为0~1000的整数
        /// </summary>
        [XmlElement("lower_bound")]
        public string LowerBound { get; set; }

        /// <summary>
        /// 店铺评分上线，必须为0~1000的整数
        /// </summary>
        [XmlElement("upper_bound")]
        public string UpperBound { get; set; }

        /// <summary>
        /// 当前店铺评分,为0~1000内的值。 可保留一位小数
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
