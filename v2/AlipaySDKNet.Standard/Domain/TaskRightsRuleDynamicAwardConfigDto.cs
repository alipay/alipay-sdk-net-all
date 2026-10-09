using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskRightsRuleDynamicAwardConfigDto Data Structure.
    /// </summary>
    [Serializable]
    public class TaskRightsRuleDynamicAwardConfigDto : AopObject
    {
        /// <summary>
        /// 动态配置列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("dynamic_award_config_data_dto")]
        public List<DynamicAwardConfigDataDto> DataList { get; set; }

        /// <summary>
        /// 封顶持续额外奖励值
        /// </summary>
        [XmlElement("reach_always_award_count")]
        public long ReachAlwaysAwardCount { get; set; }

        /// <summary>
        /// 封顶计算类型
        /// </summary>
        [XmlElement("reach_type")]
        public string ReachType { get; set; }
    }
}
