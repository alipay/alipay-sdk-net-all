using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGameopenpromoGamecenteractivityQueryResponse.
    /// </summary>
    public class AlipayUserGameopenpromoGamecenteractivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 平台活动对应图标地址
        /// </summary>
        [XmlElement("activity_icon_url")]
        public string ActivityIconUrl { get; set; }

        /// <summary>
        /// 平台活动对应的跳转链接
        /// </summary>
        [XmlElement("activity_jump_link")]
        public string ActivityJumpLink { get; set; }
    }
}
