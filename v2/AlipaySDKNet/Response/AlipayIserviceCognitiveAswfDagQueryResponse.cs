using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveAswfDagQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveAswfDagQueryResponse : AopResponse
    {
        /// <summary>
        /// 工作流id
        /// </summary>
        [XmlElement("dag_id")]
        public string DagId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// true: 业务处理成功  false: 业务处理失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
