using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationShangouTalkingGetResponse.
    /// </summary>
    public class AlipayCommerceOperationShangouTalkingGetResponse : AopResponse
    {
        /// <summary>
        /// 未绑定账号跳转地址
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 智能体回复内容
        /// </summary>
        [XmlElement("result_text")]
        public string ResultText { get; set; }
    }
}
