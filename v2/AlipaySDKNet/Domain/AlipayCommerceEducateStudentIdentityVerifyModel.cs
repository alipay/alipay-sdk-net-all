using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateStudentIdentityVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateStudentIdentityVerifyModel : AopObject
    {
        /// <summary>
        /// 单次核验业务token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }
    }
}
