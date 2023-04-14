using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NiukeExamReportCallbackRequest Data Structure.
    /// </summary>
    [Serializable]
    public class NiukeExamReportCallbackRequest : AopObject
    {
        /// <summary>
        /// 报告文件的扩展名
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 报告文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 唯一id，即应聘id
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
