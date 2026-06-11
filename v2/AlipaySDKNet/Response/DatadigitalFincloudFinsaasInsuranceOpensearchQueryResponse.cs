using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceOpensearchQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasInsuranceOpensearchQueryResponse : AopResponse
    {
        /// <summary>
        /// 调试信息
        /// </summary>
        [XmlElement("debug_info")]
        public string DebugInfo { get; set; }

        /// <summary>
        /// RAG搜索到的文档列表
        /// </summary>
        [XmlArray("search_docs")]
        [XmlArrayItem("open_search_doc_b_o")]
        public List<OpenSearchDocBO> SearchDocs { get; set; }

        /// <summary>
        /// 当参数contentType=llmWholeImage时，search_images字段返回
        /// </summary>
        [XmlArray("search_images")]
        [XmlArrayItem("open_search_image_b_o")]
        public List<OpenSearchImageBO> SearchImages { get; set; }
    }
}
