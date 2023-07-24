using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileDetectDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileDetectDetailDTO : AopObject
    {
        /// <summary>
        /// 检测项详情
        /// </summary>
        [XmlArray("detect_item_list")]
        [XmlArrayItem("apmobile_detect_item_d_t_o")]
        public List<ApmobileDetectItemDTO> DetectItemList { get; set; }

        /// <summary>
        /// 有问题的检测子项数
        /// </summary>
        [XmlElement("detect_item_problem_num")]
        public string DetectItemProblemNum { get; set; }

        /// <summary>
        /// 检测大项内的检测子项数量
        /// </summary>
        [XmlElement("detect_item_sum")]
        public string DetectItemSum { get; set; }

        /// <summary>
        /// 检测大项名称
        /// </summary>
        [XmlElement("detect_item_type")]
        public string DetectItemType { get; set; }
    }
}
