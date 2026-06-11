using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReportDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ReportDetail : AopObject
    {
        /// <summary>
        /// 报告查询详情页,h5链接
        /// </summary>
        [XmlElement("report_detail_url")]
        public string ReportDetailUrl { get; set; }

        /// <summary>
        /// 报告原件地址,必须按照页面顺序，既和页面“查看详情”安全相匹配
        /// </summary>
        [XmlElement("report_ori_url")]
        public string ReportOriUrl { get; set; }
    }
}
