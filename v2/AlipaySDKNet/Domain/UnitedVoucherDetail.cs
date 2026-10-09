using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnitedVoucherDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UnitedVoucherDetail : AopObject
    {
        /// <summary>
        /// 券激活时间
        /// </summary>
        [XmlElement("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 单据id（同一次领奖请求里领到的券的单据id相同）
        /// </summary>
        [XmlElement("camp_order_id")]
        public string CampOrderId { get; set; }

        /// <summary>
        /// 封顶金额（仅适用于折扣券）
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 券描述信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 券折扣类型
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 券过期时间
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

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
        /// 奖品发放时间
        /// </summary>
        [XmlElement("prize_send_time")]
        public string PrizeSendTime { get; set; }

        /// <summary>
        /// 券折扣比例（仅适用于折扣券）
        /// </summary>
        [XmlElement("reduction_ratio")]
        public string ReductionRatio { get; set; }

        /// <summary>
        /// 券展示顺序
        /// </summary>
        [XmlElement("show_order")]
        public long ShowOrder { get; set; }

        /// <summary>
        /// 券可用状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

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

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
