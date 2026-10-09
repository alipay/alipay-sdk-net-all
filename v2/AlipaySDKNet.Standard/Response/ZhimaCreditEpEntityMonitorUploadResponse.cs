using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorUploadResponse.
    /// </summary>
    public class ZhimaCreditEpEntityMonitorUploadResponse : AopResponse
    {
        /// <summary>
        /// 成功返回true,失败返回false
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 方案ID
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }
    }
}
