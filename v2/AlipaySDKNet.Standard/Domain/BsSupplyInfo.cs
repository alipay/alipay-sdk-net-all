using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsSupplyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BsSupplyInfo : AopObject
    {
        /// <summary>
        /// 权益优惠信息
        /// </summary>
        [XmlElement("benefit_discount")]
        public BsSupplyDiscountInfo BenefitDiscount { get; set; }

        /// <summary>
        /// 权益商品信息
        /// </summary>
        [XmlElement("benefit_item_info")]
        public BsSupplyItemInfo BenefitItemInfo { get; set; }

        /// <summary>
        /// 权益优惠描述文案
        /// </summary>
        [XmlElement("description_doc")]
        public string DescriptionDoc { get; set; }

        /// <summary>
        /// 权益子类型，如权益是优惠券时，则是优惠券类型
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 供给权益类型
        /// </summary>
        [XmlElement("suppl_type")]
        public string SupplType { get; set; }

        /// <summary>
        /// 供给权益id，优惠券场景即券活动id
        /// </summary>
        [XmlElement("supply_id")]
        public string SupplyId { get; set; }

        /// <summary>
        /// 供给权益名称，如权益类型为优惠券，则是券活动名称（非券名称）
        /// </summary>
        [XmlElement("supply_name")]
        public string SupplyName { get; set; }
    }
}
