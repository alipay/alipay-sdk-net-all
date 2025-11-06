using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniBillCertQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniBillCertQueryModel : AopObject
    {
        /// <summary>
        /// 凭证id（支付宝平台基于券码code生成的唯一id）
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }
    }
}
