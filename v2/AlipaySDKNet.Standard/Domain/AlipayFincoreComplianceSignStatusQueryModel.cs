using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceSignStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceSignStatusQueryModel : AopObject
    {
        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 用印工单文件编号
        /// </summary>
        [XmlElement("file_code")]
        public string FileCode { get; set; }

        /// <summary>
        /// 系统来源
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }
    }
}
