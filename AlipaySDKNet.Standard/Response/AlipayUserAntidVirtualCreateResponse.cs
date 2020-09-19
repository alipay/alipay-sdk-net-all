using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntidVirtualCreateResponse.
    /// </summary>
    public class AlipayUserAntidVirtualCreateResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁通行证ID
        /// </summary>
        [XmlElement("ant_id")]
        public string AntId { get; set; }

        /// <summary>
        /// 蚂蚁虚拟账户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
