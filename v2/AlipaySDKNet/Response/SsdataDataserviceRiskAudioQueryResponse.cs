using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAudioQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskAudioQueryResponse : AopResponse
    {
        /// <summary>
        /// 命中的用户自定义的关键词列表及选择的模型命中分数
        /// </summary>
        [XmlElement("risk_result")]
        public string RiskResult { get; set; }

        /// <summary>
        /// 业务唯一识别码
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
