using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppPermissionReportSummaryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppPermissionReportSummaryDTO : AopObject
    {
        /// <summary>
        /// 检测评估数量
        /// </summary>
        [XmlElement("detect_item_evaluate_num")]
        public long DetectItemEvaluateNum { get; set; }

        /// <summary>
        /// 检测未通过数量
        /// </summary>
        [XmlElement("detect_item_fail_num")]
        public long DetectItemFailNum { get; set; }

        /// <summary>
        /// 检测通过数量
        /// </summary>
        [XmlElement("detect_item_pass_num")]
        public long DetectItemPassNum { get; set; }

        /// <summary>
        /// 端权限检测报告检测项结果实体
        /// </summary>
        [XmlArray("detect_item_problem_dtos")]
        [XmlArrayItem("apmobile_detect_item_problem_d_t_o")]
        public List<ApmobileDetectItemProblemDTO> DetectItemProblemDtos { get; set; }

        /// <summary>
        /// 检测项数量
        /// </summary>
        [XmlElement("detect_item_sum")]
        public long DetectItemSum { get; set; }

        /// <summary>
        /// 检测项大类问题总数
        /// </summary>
        [XmlElement("detect_item_type_problem_sum")]
        public long DetectItemTypeProblemSum { get; set; }

        /// <summary>
        /// 检测项大类总数
        /// </summary>
        [XmlElement("detect_item_type_sum")]
        public long DetectItemTypeSum { get; set; }

        /// <summary>
        /// task_id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
