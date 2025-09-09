using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHdfaccessCifQueryResponse.
    /// </summary>
    public class AlipayCommerceHdfaccessCifQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户签约手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
    }
}
