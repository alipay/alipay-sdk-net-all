using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StagePayPlanVO Data Structure.
    /// </summary>
    [Serializable]
    public class StagePayPlanVO : AopObject
    {
        /// <summary>
        /// 阶段付款计划阶段编号，标识当前计划处于第几阶段
        /// </summary>
        [XmlElement("stage_no")]
        public long StageNo { get; set; }

        /// <summary>
        /// 阶段付款计划详情列表
        /// </summary>
        [XmlArray("stage_pay_plan_infos")]
        [XmlArrayItem("stage_pay_plan_info_v_o")]
        public List<StagePayPlanInfoVO> StagePayPlanInfos { get; set; }
    }
}
