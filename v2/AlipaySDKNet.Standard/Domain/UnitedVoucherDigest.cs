using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnitedVoucherDigest Data Structure.
    /// </summary>
    [Serializable]
    public class UnitedVoucherDigest : AopObject
    {
        /// <summary>
        /// 是否剩余预算
        /// </summary>
        [XmlElement("budget_close")]
        public bool BudgetClose { get; set; }

        /// <summary>
        /// 封顶金额（仅适用于折扣券）
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 券折扣类型：满减券/折扣券
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 券满减门槛-满金额，单位：元
        /// </summary>
        [XmlElement("from_amount")]
        public string FromAmount { get; set; }

        /// <summary>
        /// 奖品ID
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 券折扣比例（仅适用于折扣券）
        /// </summary>
        [XmlElement("reduction_ratio")]
        public string ReductionRatio { get; set; }

        /// <summary>
        /// 展示顺序
        /// </summary>
        [XmlElement("show_order")]
        public long ShowOrder { get; set; }

        /// <summary>
        /// 券满减门槛-减金额（仅适用于满减券），单位：元
        /// </summary>
        [XmlElement("to_amount")]
        public string ToAmount { get; set; }

        /// <summary>
        /// 券所属行业/类目
        /// </summary>
        [XmlElement("voucher_biz_code")]
        public string VoucherBizCode { get; set; }
    }
}
