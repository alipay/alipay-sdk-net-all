using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizVoucherConsultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BizVoucherConsultInfo : AopObject
    {
        /// <summary>
        /// 券生效时间
        /// </summary>
        [XmlElement("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 业务logo
        /// </summary>
        [XmlElement("biz_logo")]
        public string BizLogo { get; set; }

        /// <summary>
        /// 券过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 是否最优
        /// </summary>
        [XmlElement("optimal")]
        public bool Optimal { get; set; }

        /// <summary>
        /// 优惠文档
        /// </summary>
        [XmlElement("promo_text")]
        public string PromoText { get; set; }

        /// <summary>
        /// 券优惠类型
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 券使用门槛文案
        /// </summary>
        [XmlElement("use_threshold_text")]
        public string UseThresholdText { get; set; }

        /// <summary>
        /// 券实例id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券查看跳转链接
        /// </summary>
        [XmlElement("voucher_link_url")]
        public string VoucherLinkUrl { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券面值 优惠类型=折扣券(DISCOUNT_VOUCHER)时,券面值=折扣,如:0,88; 优惠类型=满减券(FIX_VOUCHER)时,券面值=券金额,如0.5,单位:元; 优惠类型=立减券(REDUCTION_VOUCHER)时,券面值=券金额,如0.8,单位:元; 优惠类型=减至券(REDUCTION_TO_VOUCHER),券面值=减至金额,如99.01,单位:元 优惠类型=特价券(SPECIAL_VOUCHER),券面值=特价金额,如669,单位:元
        /// </summary>
        [XmlElement("voucher_value")]
        public string VoucherValue { get; set; }
    }
}
