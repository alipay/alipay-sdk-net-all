using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateQueryInfo : AopObject
    {
        /// <summary>
        /// 凭证实例的金额信息，在异常场景下可能为空，需要判断是否有值才可进行使用。
        /// </summary>
        [XmlElement("amount_info")]
        public CertificateInstanceAmountInfo AmountInfo { get; set; }

        /// <summary>
        /// 当前凭证是否可用，如传入门店id，则会判断当前门店、当前时间是否可使用此凭证；如未传入门店id，仅返回当前时间是否可使用。
        /// </summary>
        [XmlElement("can_use")]
        public string CanUse { get; set; }

        /// <summary>
        /// 用户凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 三方码凭证券码。
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 商家侧核销对应的交易订单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("sku_info")]
        public CertificateSkuInfo SkuInfo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 次卡详情，商品类型为次卡时该值必填
        /// </summary>
        [XmlElement("times_card_info")]
        public CertificateTimesCardInfo TimesCardInfo { get; set; }

        /// <summary>
        /// 核销规则
        /// </summary>
        [XmlElement("use_rule_info")]
        public CertificateUseRuleInfo UseRuleInfo { get; set; }

        /// <summary>
        /// 开始生效时间
        /// </summary>
        [XmlElement("valid_begin_time")]
        public string ValidBeginTime { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }
    }
}
