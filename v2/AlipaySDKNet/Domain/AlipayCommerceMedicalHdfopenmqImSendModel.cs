using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfopenmqImSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfopenmqImSendModel : AopObject
    {
        /// <summary>
        /// 消息幂等id
        /// </summary>
        [XmlElement("bizid")]
        public string Bizid { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 好大夫消息id
        /// </summary>
        [XmlElement("msgid")]
        public string Msgid { get; set; }
    }
}
