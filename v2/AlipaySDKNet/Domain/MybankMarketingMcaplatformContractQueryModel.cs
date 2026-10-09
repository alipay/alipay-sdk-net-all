using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankMarketingMcaplatformContractQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankMarketingMcaplatformContractQueryModel : AopObject
    {
        /// <summary>
        /// biz_date，不唯一，绿色经营外部传入业务时间，无枚举值，可为空
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// cert_no，不唯一，绿色经营接口传入证件号，无枚举值，目前仅支持传入同一社会信用代码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// cert_type，唯一，绿色经营接口传入证件类型，枚举值UNIFIED_SOCIAL_CREDIT_CODE_CERTIFICATE，目前仅有社会信用代码枚举
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// channel，不唯一，绿色经营调用方系统名，无枚举值
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }
    }
}
