using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinFrameworkDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FinFrameworkDetail : AopObject
    {
        /// <summary>
        /// 框架编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 评价标准
        /// </summary>
        [XmlElement("evaluation_standard")]
        public string EvaluationStandard { get; set; }

        /// <summary>
        /// 专家知识
        /// </summary>
        [XmlElement("expert_knowledge")]
        public string ExpertKnowledge { get; set; }

        /// <summary>
        /// 表达要求
        /// </summary>
        [XmlElement("expression_requirements")]
        public string ExpressionRequirements { get; set; }

        /// <summary>
        /// 解读思路
        /// </summary>
        [XmlElement("interpretation_thoughts")]
        public string InterpretationThoughts { get; set; }

        /// <summary>
        /// 框架介绍
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 框架名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 收集信息内容
        /// </summary>
        [XmlElement("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// 框架顺序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }
    }
}
