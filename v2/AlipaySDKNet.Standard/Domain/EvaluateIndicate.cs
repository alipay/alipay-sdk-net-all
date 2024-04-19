using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EvaluateIndicate Data Structure.
    /// </summary>
    [Serializable]
    public class EvaluateIndicate : AopObject
    {
        /// <summary>
        /// 子指标id列表
        /// </summary>
        [XmlArray("children_ids")]
        [XmlArrayItem("evalute_indicate_id")]
        public List<EvaluteIndicateId> ChildrenIds { get; set; }

        /// <summary>
        /// 评分指标列表
        /// </summary>
        [XmlArray("grade_indicates")]
        [XmlArrayItem("evaluate_indicate_grade")]
        public List<EvaluateIndicateGrade> GradeIndicates { get; set; }

        /// <summary>
        /// 商户指标描述
        /// </summary>
        [XmlElement("isv_indicate_desc")]
        public string IsvIndicateDesc { get; set; }

        /// <summary>
        /// 商户指标id
        /// </summary>
        [XmlElement("isv_indicate_id")]
        public string IsvIndicateId { get; set; }

        /// <summary>
        /// 商户指标图片
        /// </summary>
        [XmlElement("isv_indicate_img")]
        public string IsvIndicateImg { get; set; }

        /// <summary>
        /// 商户指标名称
        /// </summary>
        [XmlElement("isv_indicate_name")]
        public string IsvIndicateName { get; set; }
    }
}
