using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrTablesQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrTablesQueryResponse : AopResponse
    {
        /// <summary>
        /// true：识别成功  false: 识别失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 表格内容
        /// </summary>
        [XmlArray("tables")]
        [XmlArrayItem("ai_ocr_table_row")]
        public List<AiOcrTableRow> Tables { get; set; }

        /// <summary>
        /// 服务请求唯一标示id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
