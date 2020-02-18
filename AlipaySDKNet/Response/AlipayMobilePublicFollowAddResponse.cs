using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicFollowAddResponse.
    /// </summary>
    public class AlipayMobilePublicFollowAddResponse : AopResponse
    {
        /// <summary>
        /// 成功与否的标志
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }
    }
}
