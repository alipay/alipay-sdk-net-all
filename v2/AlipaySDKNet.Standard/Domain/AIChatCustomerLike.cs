using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AIChatCustomerLike Data Structure.
    /// </summary>
    [Serializable]
    public class AIChatCustomerLike : AopObject
    {
        /// <summary>
        /// 是否第一次进行对话
        /// </summary>
        [XmlElement("first_chat")]
        public bool FirstChat { get; set; }

        /// <summary>
        /// 输入方式
        /// </summary>
        [XmlElement("input_method")]
        public string InputMethod { get; set; }
    }
}
