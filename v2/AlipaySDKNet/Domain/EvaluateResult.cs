using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EvaluateResult Data Structure.
    /// </summary>
    [Serializable]
    public class EvaluateResult : AopObject
    {
        /// <summary>
        /// 有效调节电量，单位：kWh
        /// </summary>
        [XmlElement("actual_energy")]
        public string ActualEnergy { get; set; }

        /// <summary>
        /// 预估收益，单位：元
        /// </summary>
        [XmlElement("estimate_profit")]
        public string EstimateProfit { get; set; }

        /// <summary>
        /// 响应评价有效调节量
        /// </summary>
        [XmlArray("evaluate_adjustment")]
        [XmlArrayItem("load_info_node")]
        public List<LoadInfoNode> EvaluateAdjustment { get; set; }

        /// <summary>
        /// 响应评价运行功率
        /// </summary>
        [XmlArray("evaluate_load")]
        [XmlArrayItem("load_info_node")]
        public List<LoadInfoNode> EvaluateLoad { get; set; }

        /// <summary>
        /// 有效响应比率（%）
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }

        /// <summary>
        /// 实际调节电量，单位：kWh
        /// </summary>
        [XmlElement("real_energy")]
        public string RealEnergy { get; set; }

        /// <summary>
        /// 实际运行负荷，单位：kW
        /// </summary>
        [XmlElement("real_load")]
        public string RealLoad { get; set; }

        /// <summary>
        /// 响应结束时间
        /// </summary>
        [XmlElement("response_end_time")]
        public string ResponseEndTime { get; set; }

        /// <summary>
        /// 响应开始时间
        /// </summary>
        [XmlElement("response_start_time")]
        public string ResponseStartTime { get; set; }

        /// <summary>
        /// 目标调节电量，单位：kWh
        /// </summary>
        [XmlElement("target_energy")]
        public string TargetEnergy { get; set; }

        /// <summary>
        /// 目标运行负荷，单位：kW
        /// </summary>
        [XmlElement("target_load")]
        public string TargetLoad { get; set; }
    }
}
