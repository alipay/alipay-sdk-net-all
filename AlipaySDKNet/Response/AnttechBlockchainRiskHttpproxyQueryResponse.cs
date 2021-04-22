using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainRiskHttpproxyQueryResponse.
    /// </summary>
    public class AnttechBlockchainRiskHttpproxyQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回接口数据，例如mps模型，只有标签和评分，无个人敏感信息
        /// </summary>
        [XmlElement("response")]
        public string Response { get; set; }

        /// <summary>
        /// 响应成功与否
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 业务唯一识别码traceId
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
