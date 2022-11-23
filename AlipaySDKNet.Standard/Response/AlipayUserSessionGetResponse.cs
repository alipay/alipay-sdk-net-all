using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSessionGetResponse.
    /// </summary>
    public class AlipayUserSessionGetResponse : AopResponse
    {
        /// <summary>
        /// 用户在应用下的唯一用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户在应用分组下的唯一用户标识
        /// </summary>
        [XmlElement("union_id")]
        public string UnionId { get; set; }
    }
}
