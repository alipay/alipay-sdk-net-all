using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdFileConvertCreateResponse.
    /// </summary>
    public class AlipaySecurityProdFileConvertCreateResponse : AopResponse
    {
        /// <summary>
        /// 转换任务id
        /// </summary>
        [XmlElement("convert_task_id")]
        public string ConvertTaskId { get; set; }

        /// <summary>
        /// 转换目标路径
        /// </summary>
        [XmlElement("target_file_path")]
        public string TargetFilePath { get; set; }
    }
}
