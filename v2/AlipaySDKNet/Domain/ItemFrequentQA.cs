using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemFrequentQA Data Structure.
    /// </summary>
    [Serializable]
    public class ItemFrequentQA : AopObject
    {
        /// <summary>
        /// 回答
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 问题
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }
    }
}
