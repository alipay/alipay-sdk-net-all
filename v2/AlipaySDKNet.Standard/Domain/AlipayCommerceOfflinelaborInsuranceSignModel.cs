using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOfflinelaborInsuranceSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOfflinelaborInsuranceSignModel : AopObject
    {
        /// <summary>
        /// 保险模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 外部业务登记号，用于业务幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 企业的社会信用统一代码，18位
        /// </summary>
        [XmlElement("social_unified_cert_no")]
        public string SocialUnifiedCertNo { get; set; }
    }
}
