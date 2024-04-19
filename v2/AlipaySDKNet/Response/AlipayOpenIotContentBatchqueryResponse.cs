using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotContentBatchqueryResponse.
    /// </summary>
    public class AlipayOpenIotContentBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 格式取决于查询数据的场景
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("string")]
        public List<string> ContentList { get; set; }

        /// <summary>
        /// 总数据条数
        /// </summary>
        [XmlElement("list_total_count")]
        public long ListTotalCount { get; set; }

        /// <summary>
        /// 错误说明，错误情况会包含通用错误码中不包含的场景错误信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 查询结果码，根据不同场景可能有所不同
        /// </summary>
        [XmlElement("query_result_code")]
        public string QueryResultCode { get; set; }

        /// <summary>
        /// 内容查询埋点，内部应用与外部调用的串联埋点
        /// </summary>
        [XmlElement("query_token")]
        public string QueryToken { get; set; }
    }
}
