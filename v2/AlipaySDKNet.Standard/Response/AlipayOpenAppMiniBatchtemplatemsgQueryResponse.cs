using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppMiniBatchtemplatemsgQueryResponse.
    /// </summary>
    public class AlipayOpenAppMiniBatchtemplatemsgQueryResponse : AopResponse
    {
        /// <summary>
        /// 消息批量发送记录
        /// </summary>
        [XmlElement("record")]
        public BatchTemplateMsgRecordVO Record { get; set; }
    }
}
