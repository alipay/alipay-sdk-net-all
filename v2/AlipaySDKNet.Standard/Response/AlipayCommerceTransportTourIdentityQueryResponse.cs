using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTourIdentityQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTourIdentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询返回结果
        /// </summary>
        [XmlElement("identity_result")]
        public string IdentityResult { get; set; }
    }
}
