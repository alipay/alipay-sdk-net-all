using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationObjectQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveClassificationObjectQueryResponse : AopResponse
    {
        /// <summary>
        /// 识别类型
        /// </summary>
        [XmlElement("cognition_type")]
        public string CognitionType { get; set; }

        /// <summary>
        /// 错误编码
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 关键字识别列表
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("object_key_word")]
        public List<ObjectKeyWord> KeyWords { get; set; }

        /// <summary>
        /// 原始内容
        /// </summary>
        [XmlElement("origin_content")]
        public string OriginContent { get; set; }

        /// <summary>
        /// 平台实际使用内容
        /// </summary>
        [XmlElement("rewrite_content")]
        public string RewriteContent { get; set; }

        /// <summary>
        /// 接口是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// trace
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
