using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntpaasTokenCreateResponse.
    /// </summary>
    public class AlipayUserAntpaasTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁通行证id
        /// </summary>
        [XmlElement("ant_id")]
        public string AntId { get; set; }
    }
}
