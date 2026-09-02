using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuestionInfoOpenapiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class QuestionInfoOpenapiResponse : AopObject
    {
        /// <summary>
        /// 答案输入类型
        /// </summary>
        [XmlElement("input_type")]
        public string InputType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("option_item_response")]
        public List<OptionItemResponse> Options { get; set; }

        /// <summary>
        /// 问题ID
        /// </summary>
        [XmlElement("question_biz_id")]
        public string QuestionBizId { get; set; }

        /// <summary>
        /// 问题分类
        /// </summary>
        [XmlElement("question_category")]
        public string QuestionCategory { get; set; }

        /// <summary>
        /// 问题
        /// </summary>
        [XmlElement("question_content")]
        public string QuestionContent { get; set; }

        /// <summary>
        /// 问题填写描述
        /// </summary>
        [XmlElement("question_desc")]
        public string QuestionDesc { get; set; }

        /// <summary>
        /// 问题排序
        /// </summary>
        [XmlElement("question_sort_order")]
        public long QuestionSortOrder { get; set; }

        /// <summary>
        /// 问题是否必须回答
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }
    }
}
