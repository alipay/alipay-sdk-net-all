using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntidVirtualQueryResponse.
    /// </summary>
    public class AlipayUserAntidVirtualQueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁通行证ID
        /// </summary>
        [XmlElement("ant_id")]
        public string AntId { get; set; }

        /// <summary>
        /// 额外附加信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 蚂蚁虚拟账户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
