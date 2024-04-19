using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAgreementUserverifyQueryResponse.
    /// </summary>
    public class AlipayUserAgreementUserverifyQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户信息是否匹配
        /// </summary>
        [XmlElement("user_match")]
        public bool UserMatch { get; set; }
    }
}
