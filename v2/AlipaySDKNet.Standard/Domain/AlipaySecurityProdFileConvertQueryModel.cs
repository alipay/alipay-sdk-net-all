using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdFileConvertQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdFileConvertQueryModel : AopObject
    {
        /// <summary>
        /// 阿里云文件异步转换任务id
        /// </summary>
        [XmlElement("convert_task_id")]
        public string ConvertTaskId { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 文件转换目标目录
        /// </summary>
        [XmlElement("target_file_path")]
        public string TargetFilePath { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
