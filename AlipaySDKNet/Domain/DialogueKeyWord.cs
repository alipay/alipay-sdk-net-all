using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DialogueKeyWord Data Structure.
    /// </summary>
    [Serializable]
    public class DialogueKeyWord : AopObject
    {
        /// <summary>
        /// 高亮关键词位置-单句开始下标位置 例：abcd，b是1位置开始
        /// </summary>
        [XmlElement("from")]
        public long From { get; set; }

        /// <summary>
        /// 命中结果高亮，备选--单句结束下标位置 例：abcd，b是2位置结束
        /// </summary>
        [XmlElement("to")]
        public long To { get; set; }
    }
}
