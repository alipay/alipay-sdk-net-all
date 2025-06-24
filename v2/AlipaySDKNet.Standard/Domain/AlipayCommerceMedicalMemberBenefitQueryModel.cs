using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMemberBenefitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMemberBenefitQueryModel : AopObject
    {
        /// <summary>
        /// 商品参加的权益活动编码，通过商详跳转后缀参数benefitActivityId获取
        /// </summary>
        [XmlElement("benefit_activity_id")]
        public string BenefitActivityId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部商户商品ID，会结合当前请求PID来查询对应商品
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// MEDICAL_DRUG - 医药商品 MEDICAL_EXAMINATION - 体检商品 MEDICAL_COSMETOLOGY - 医美商品 MEDICAL_MOUTH - 口腔商品
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// ORCAS_SAAS - 虎鲸购药
        /// </summary>
        [XmlElement("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
