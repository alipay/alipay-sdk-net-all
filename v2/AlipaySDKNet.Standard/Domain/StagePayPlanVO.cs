using System;
using System.Xml.Serialization;

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
        [XmlElement("stage_pay_plan_infos")]
        public StagePayPlanInfoVO StagePayPlanInfos { get; set; }
    }
}
