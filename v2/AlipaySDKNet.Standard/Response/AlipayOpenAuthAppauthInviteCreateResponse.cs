using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthAppauthInviteCreateResponse.
    /// </summary>
    public class AlipayOpenAuthAppauthInviteCreateResponse : AopResponse
    {
        /// <summary>
        /// 商户授权的详情页地址
        /// </summary>
        [XmlElement("task_page_url")]
        public string TaskPageUrl { get; set; }
    }
}
