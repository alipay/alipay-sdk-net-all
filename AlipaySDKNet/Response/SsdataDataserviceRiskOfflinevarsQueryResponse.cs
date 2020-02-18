using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// SsdataDataserviceRiskOfflinevarsQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskOfflinevarsQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果，包含所有维度的结果数据，两层json格式
        /// </summary>
        [XmlElement("query_result")]
        public string QueryResult { get; set; }

        /// <summary>
        /// 调用是否成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 业务唯一识别码
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
