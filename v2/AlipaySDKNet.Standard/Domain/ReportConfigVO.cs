using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReportConfigVO Data Structure.
    /// </summary>
    [Serializable]
    public class ReportConfigVO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("job_codes")]
        [XmlArrayItem("string")]
        public List<string> JobCodes { get; set; }

        /// <summary>
        /// 自定义跳转地址
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 上报类型
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }
    }
}
