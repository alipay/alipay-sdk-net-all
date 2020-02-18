using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationWasteQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveClassificationWasteQueryResponse : AopResponse
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
        [XmlArrayItem("key_word_d_t_o")]
        public List<KeyWordDTO> KeyWords { get; set; }

        /// <summary>
        /// 原始输入内容
        /// </summary>
        [XmlElement("origin_content")]
        public string OriginContent { get; set; }

        /// <summary>
        /// 纠错后的文本
        /// </summary>
        [XmlElement("rewrite_content")]
        public string RewriteContent { get; set; }

        /// <summary>
        /// 接口是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// traceid
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
