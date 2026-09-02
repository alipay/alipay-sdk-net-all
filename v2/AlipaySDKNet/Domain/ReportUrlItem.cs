using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReportUrlItem Data Structure.
    /// </summary>
    [Serializable]
    public class ReportUrlItem : AopObject
    {
        /// <summary>
        /// 报告文件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 报告链接路径
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
