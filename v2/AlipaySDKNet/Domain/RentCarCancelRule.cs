using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarCancelRule Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarCancelRule : AopObject
    {
        /// <summary>
        /// 规则内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 是否免费取消
        /// </summary>
        [XmlElement("free_cancel")]
        public bool FreeCancel { get; set; }

        /// <summary>
        /// 取消规则的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
