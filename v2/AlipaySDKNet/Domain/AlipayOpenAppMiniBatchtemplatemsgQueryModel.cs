using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppMiniBatchtemplatemsgQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMiniBatchtemplatemsgQueryModel : AopObject
    {
        /// <summary>
        /// 批量发送记录ID，唯一标识一次消息模板批量查询
        /// </summary>
        [XmlElement("batch_msg_id")]
        public string BatchMsgId { get; set; }
    }
}
