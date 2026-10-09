using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountDetailInfo : AopObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 优惠明细ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优惠券类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
