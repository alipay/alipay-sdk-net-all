using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageSendResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMessageSendResponse : AopResponse
    {
        /// <summary>
        /// 短信发送回执id;可根据发送回执id在接口techrisk.innovate.message.details.query中查询具体的发送状态。
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
