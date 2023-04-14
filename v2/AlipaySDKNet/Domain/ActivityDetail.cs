using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityDetail : AopObject
    {
        /// <summary>
        /// 权益id，领奖时的凭证。领奖凭证应该保证唯一，以保证后续领奖时能够识别领取人身份。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动类型。  取值范围为枚举值： VOUCHER 券  目前仅支持发券
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 限制。 根据不同的voucherType，会有其对应的券模板，用于对消费者展示 详见券模板说明文档
        /// </summary>
        [XmlElement("voucher_constraint")]
        public string VoucherConstraint { get; set; }

        /// <summary>
        /// 券描述 根据不同的voucherType，会有其对应的券模板，用于对消费者展示 详见券模板说明文档
        /// </summary>
        [XmlElement("voucher_desc")]
        public string VoucherDesc { get; set; }

        /// <summary>
        /// 券权益。 根据不同的voucherType，会有其对应的券模板，用于对消费者展示 详见券模板说明文档
        /// </summary>
        [XmlElement("voucher_interest")]
        public string VoucherInterest { get; set; }

        /// <summary>
        /// 券类型，目前支持以下种类： 全场满减:  GLOBAL_FIX_VOUCHER 全场折扣: GLOBAL_DISCOUNT_VOUCHER 单品满减：ITEM_FIX_VOUCHER 单品折扣： ITEM_DISCOUNT_VOUCHER 单品特价： ITEM_SPECIAL_VOUCHER
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
