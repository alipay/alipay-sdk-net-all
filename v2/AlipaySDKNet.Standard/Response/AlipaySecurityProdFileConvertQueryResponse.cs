using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdFileConvertQueryResponse.
    /// </summary>
    public class AlipaySecurityProdFileConvertQueryResponse : AopResponse
    {
        /// <summary>
        /// pdf完整文件地址
        /// </summary>
        [XmlElement("pdf_presigned_url")]
        public string PdfPresignedUrl { get; set; }

        /// <summary>
        /// true表示异步任务结束，false表示未结束
        /// </summary>
        [XmlElement("task_result")]
        public bool TaskResult { get; set; }
    }
}
