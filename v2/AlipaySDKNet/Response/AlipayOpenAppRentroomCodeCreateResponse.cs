using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppRentroomCodeCreateResponse.
    /// </summary>
    public class AlipayOpenAppRentroomCodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 吱口令
        /// </summary>
        [XmlElement("share_token")]
        public string ShareToken { get; set; }
    }
}
