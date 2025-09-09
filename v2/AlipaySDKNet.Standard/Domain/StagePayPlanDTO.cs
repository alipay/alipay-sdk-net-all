using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StagePayPlanDTO Data Structure.
    /// </summary>
    [Serializable]
    public class StagePayPlanDTO : AopObject
    {
        /// <summary>
        /// 阶段付款计划阶段编号，标识当前计划处于第几阶段，起始值为1，多阶段需保证阶段编号递增
        /// </summary>
        [XmlElement("stage_no")]
        public long StageNo { get; set; }

        /// <summary>
        /// 阶段付款计划详情列表
        /// </summary>
        [XmlArray("stage_pay_plan_infos")]
        [XmlArrayItem("stage_pay_plan_info_d_t_o")]
        public List<StagePayPlanInfoDTO> StagePayPlanInfos { get; set; }
    }
}
