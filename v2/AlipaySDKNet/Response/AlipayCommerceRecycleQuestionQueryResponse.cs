using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleQuestionQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleQuestionQueryResponse : AopResponse
    {
        /// <summary>
        /// 问卷选项约束关系
        /// </summary>
        [XmlArray("option_constraint_relations")]
        [XmlArrayItem("recycle_option_constraint")]
        public List<RecycleOptionConstraint> OptionConstraintRelations { get; set; }

        /// <summary>
        /// 问卷集合
        /// </summary>
        [XmlArray("questions")]
        [XmlArrayItem("recycle_quetion")]
        public List<RecycleQuetion> Questions { get; set; }
    }
}
