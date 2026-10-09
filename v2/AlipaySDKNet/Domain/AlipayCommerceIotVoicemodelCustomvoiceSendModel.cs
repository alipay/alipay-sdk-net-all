using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotVoicemodelCustomvoiceSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotVoicemodelCustomvoiceSendModel : AopObject
    {
        /// <summary>
        /// 服务调用上下文
        /// </summary>
        [XmlElement("context")]
        public ServiceModelContext Context { get; set; }

        /// <summary>
        /// 自定义语音调用模型
        /// </summary>
        [XmlElement("custom_voice")]
        public CustomVoiceVO CustomVoice { get; set; }
    }
}
