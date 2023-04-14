using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardTemplateOperationItem Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardTemplateOperationItem : AopObject
    {
        /// <summary>
        /// 卡模板操作项的文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 卡模板操作项的跳转链接, 支持 小程序地址 或者 官方h5地址。
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
