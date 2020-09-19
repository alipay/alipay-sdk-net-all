using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertdocCertverifyConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertdocCertverifyConsultModel : AopObject
    {
        /// <summary>
        /// 信息校验验证ID
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
