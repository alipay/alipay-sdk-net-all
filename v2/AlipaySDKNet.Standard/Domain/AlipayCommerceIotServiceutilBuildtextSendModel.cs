using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotServiceutilBuildtextSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotServiceutilBuildtextSendModel : AopObject
    {
        /// <summary>
        /// 要合成语音文件的文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
