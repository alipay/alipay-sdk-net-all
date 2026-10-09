using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DynamicRentBillingRuleMultiStageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DynamicRentBillingRuleMultiStageDTO : AopObject
    {
        /// <summary>
        /// 计费上限(单位元),最多2位小数
        /// </summary>
        [XmlElement("billing_cap")]
        public string BillingCap { get; set; }

        /// <summary>
        /// 每阶段租金配置信息
        /// </summary>
        [XmlArray("stage_amount_config_list")]
        [XmlArrayItem("multi_stage_amount_config_d_t_o")]
        public List<MultiStageAmountConfigDTO> StageAmountConfigList { get; set; }
    }
}
