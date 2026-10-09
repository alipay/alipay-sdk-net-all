using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeMsgRecallModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLifeMsgRecallModel : AopObject
    {
        /// <summary>
        /// 消息id，可在调用<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.message.total.send">群发消息</a>、<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.message.group.send">组发消息</a>接口时会返回，请注意保存留用。
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }
    }
}
