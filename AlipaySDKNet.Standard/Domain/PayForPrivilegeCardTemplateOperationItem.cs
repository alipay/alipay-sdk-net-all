using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayForPrivilegeCardTemplateOperationItem Data Structure.
    /// </summary>
    [Serializable]
    public class PayForPrivilegeCardTemplateOperationItem : AopObject
    {
        /// <summary>
        /// 卡模板操作项的文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 卡模板操作项的跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
