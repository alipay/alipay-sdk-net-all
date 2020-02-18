using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataRiskRtopobtsregQueryResponse.
    /// </summary>
    public class AlipayDataRiskRtopobtsregQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询后端ssdataprod应用的返回数据
        /// </summary>
        [XmlElement("query_result")]
        public string QueryResult { get; set; }

        /// <summary>
        /// 调用是否成功标识
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }

        /// <summary>
        /// unqiue_id+业务唯一识别码traceId
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
