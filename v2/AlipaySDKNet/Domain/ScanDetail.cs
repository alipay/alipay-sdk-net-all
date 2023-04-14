using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScanDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ScanDetail : AopObject
    {
        /// <summary>
        /// 扫描报告
        /// </summary>
        [XmlElement("scan_report")]
        public string ScanReport { get; set; }

        /// <summary>
        /// 扫描状态
        /// </summary>
        [XmlElement("scan_state")]
        public string ScanState { get; set; }

        /// <summary>
        /// 扫描类型
        /// </summary>
        [XmlElement("scan_type")]
        public string ScanType { get; set; }
    }
}
