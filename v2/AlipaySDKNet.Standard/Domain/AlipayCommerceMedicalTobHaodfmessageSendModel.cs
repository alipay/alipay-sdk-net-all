using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalTobHaodfmessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalTobHaodfmessageSendModel : AopObject
    {
        /// <summary>
        /// 消息体
        /// </summary>
        [XmlElement("msg_content")]
        public string MsgContent { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
