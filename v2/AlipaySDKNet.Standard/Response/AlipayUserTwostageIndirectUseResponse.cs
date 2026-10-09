using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserTwostageIndirectUseResponse.
    /// </summary>
    public class AlipayUserTwostageIndirectUseResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
