using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizGrantPlan Data Structure.
    /// </summary>
    [Serializable]
    public class BizGrantPlan : AopObject
    {
        /// <summary>
        /// 商户品牌链接
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 商户品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 发放时间
        /// </summary>
        [XmlElement("grant_time")]
        public string GrantTime { get; set; }

        /// <summary>
        /// 发放主体
        /// </summary>
        [XmlElement("issuer_type")]
        public string IssuerType { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 联合权益描述
        /// </summary>
        [XmlElement("rights_desc")]
        public string RightsDesc { get; set; }

        /// <summary>
        /// 券张数
        /// </summary>
        [XmlElement("voucher_count")]
        public long VoucherCount { get; set; }

        /// <summary>
        /// 券使用链接
        /// </summary>
        [XmlElement("voucher_link_url")]
        public string VoucherLinkUrl { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券状态
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }

        /// <summary>
        /// 券单位
        /// </summary>
        [XmlElement("voucher_unit")]
        public string VoucherUnit { get; set; }

        /// <summary>
        /// 券面值 优惠类型=折扣券(DISCOUNT_VOUCHER)时,券面值=折扣,如:0,88; 优惠类型=满减券(FIX_VOUCHER)时,券面值=券金额,如0.5,单位:元; 优惠类型=立减券(REDUCTION_VOUCHER)时,券面值=券金额,如0.8,单位:元; 优惠类型=减至券(REDUCTION_TO_VOUCHER),券面值=减至金额,如99.01,单位:元 优惠类型=特价券(SPECIAL_VOUCHER),券面值=特价金额,如669,单位:元
        /// </summary>
        [XmlElement("voucher_value")]
        public string VoucherValue { get; set; }
    }
}
