using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOfflinelaborInsuranceRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOfflinelaborInsuranceRecommendModel : AopObject
    {
        /// <summary>
        /// 企业的社会统一信用代码，18位
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 保险模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 企业联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
