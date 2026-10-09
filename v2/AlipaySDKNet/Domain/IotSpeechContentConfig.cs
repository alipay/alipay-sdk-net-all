using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotSpeechContentConfig Data Structure.
    /// </summary>
    [Serializable]
    public class IotSpeechContentConfig : AopObject
    {
        /// <summary>
        /// 该设备的非支付宝交易到账时的播报语料，语料只允许设置中文，且语料末尾有且需要包含一个占位符%s，%s代表交易金额，内容为“xx元”。如配置“收款%s”，当调用到账播报接口传入金额10.5，则设备会播报“收款10.5元”。 当传入新语料时，会进行语料注册，接口会返回新注册的语料ID，如果传入已有语料，则会返回已有语料ID。
        /// </summary>
        [XmlElement("speech_content")]
        public string SpeechContent { get; set; }
    }
}
