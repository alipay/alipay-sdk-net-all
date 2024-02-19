using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniIcpFaceauthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniIcpFaceauthQueryModel : AopObject
    {
        /// <summary>
        /// 人脸核验凭证certify_id
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
