using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudTraasRiskgoAwardingQueryResponse.
    /// </summary>
    public class AlipayCloudTraasRiskgoAwardingQueryResponse : AopResponse
    {
        /// <summary>
        /// risk_result:风险分析结果，类型为列表，包含风险分析结果和描述。分别是 risk_type:[固定值]; risk_value:仅为样例("rank0","rank1",...,"rank5",...); risk_desc:[风险等级]; 每一次返回，根据配置的不同，可以返回同样的风险结果类型，也可以返回不同的风险结果类型。其中rank0代表无匹配的风险结果/查询无结果， 其余等级随着数字增大代表风险越大。 不同场景对应的等级个数不相同，可查看介绍文档
        /// </summary>
        [XmlElement("risk_result")]
        public RiskImagePlusQueryResult RiskResult { get; set; }
    }
}
