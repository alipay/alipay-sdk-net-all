using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FixProblemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FixProblemDTO : AopObject
    {
        /// <summary>
        /// 问题的唯一id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 问题类型的一级分类
        /// </summary>
        [XmlElement("problem_level_1")]
        public string ProblemLevel1 { get; set; }

        /// <summary>
        /// 问题类型的二级分类
        /// </summary>
        [XmlElement("problem_level_2")]
        public string ProblemLevel2 { get; set; }

        /// <summary>
        /// 问题类型的三级分类
        /// </summary>
        [XmlElement("problem_level_3")]
        public string ProblemLevel3 { get; set; }
    }
}
