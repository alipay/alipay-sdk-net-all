using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRiskInfoIdentifyResponse.
    /// </summary>
    public class ZhimaCreditEpRiskInfoIdentifyResponse : AopResponse
    {
        /// <summary>
        /// {        // 策略名称       "strategyName":"企业存在诉讼被告",        // 策略显示内容       "strategyShowContent":"企业近24个月涉及诉讼被告188次",       // 策略命中标识       "strategyHitFlag": true,       // 命中策略的值       "strategyValue":"188",       // 策略值类型       "strategyValueType":"LONG",       // 策略值状态 SUCCESS/FAILURE       "strategyValueStatus":"SUCCESS",       // 风险等级 SIGNIFICANT_RISK/PROMPT_RISK       "riskLevel":"SIGNIFICANT_RISK",       // 策略id       "strategyId":"f_rt_this_tertiary_040151",       // 是否有详情feeds       "hasDetail":true     }
        /// </summary>
        [XmlArray("risk_strategy_list")]
        [XmlArrayItem("risk_strategy")]
        public List<RiskStrategy> RiskStrategyList { get; set; }
    }
}
