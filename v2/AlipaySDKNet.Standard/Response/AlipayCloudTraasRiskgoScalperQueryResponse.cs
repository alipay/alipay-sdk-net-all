using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudTraasRiskgoScalperQueryResponse.
    /// </summary>
    public class AlipayCloudTraasRiskgoScalperQueryResponse : AopResponse
    {
        /// <summary>
        /// risk_result:风险分析结果，类型为列表，包含风险分析结果和描述。分别是 risk_type:industry_scalper_common; risk_value:("noRisk","rank1",...,"rank5",...,); risk_desc:是否有风险/风险等级; rank1到rank5风险等级从低到高。以上仅为示例具体等级分类可能存在个性化配置，可以咨询蚂蚁风控同学。
        /// </summary>
        [XmlElement("risk_result")]
        public RiskImagePlusQueryResult RiskResult { get; set; }
    }
}
