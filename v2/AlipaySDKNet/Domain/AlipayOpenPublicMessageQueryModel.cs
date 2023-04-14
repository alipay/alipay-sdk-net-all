using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessageQueryModel : AopObject
    {
        /// <summary>
        /// 消息id集，最多传入20个message_id。 message_id 可在调用<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.message.total.send">群发消息</a>、<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.message.group.send">组发消息</a>接口时会返回，请注意保存留用。
        /// </summary>
        [XmlArray("message_ids")]
        [XmlArrayItem("string")]
        public List<string> MessageIds { get; set; }
    }
}
