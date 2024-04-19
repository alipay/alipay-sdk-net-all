using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInspetprodShielduserQueryResponse.
    /// </summary>
    public class AlipayInsSceneInspetprodShielduserQueryResponse : AopResponse
    {
        /// <summary>
        /// 微信昵称
        /// </summary>
        [XmlElement("shield_wx_title")]
        public string ShieldWxTitle { get; set; }

        /// <summary>
        /// 微信头像url
        /// </summary>
        [XmlElement("shield_wx_url")]
        public string ShieldWxUrl { get; set; }
    }
}
