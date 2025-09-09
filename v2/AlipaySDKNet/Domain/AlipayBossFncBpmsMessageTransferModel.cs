using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncBpmsMessageTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncBpmsMessageTransferModel : AopObject
    {
        /// <summary>
        /// bpms消息内容
        /// </summary>
        [XmlElement("bpms_message_dto")]
        public BpmsMessageDTO BpmsMessageDto { get; set; }
    }
}
