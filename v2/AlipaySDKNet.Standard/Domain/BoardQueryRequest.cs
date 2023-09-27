using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoardQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class BoardQueryRequest : AopObject
    {
        /// <summary>
        /// 人群id，人群概览查询时必传
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 只适用于资产总览查询，exclude_import=true表示查询排除导入用户后的数据看板，否则默认不排除。
        /// </summary>
        [XmlElement("exclude_import")]
        public bool ExcludeImport { get; set; }

        /// <summary>
        /// 数据日期，格式yyyyMMdd
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
