using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseRelationCombinedQueryResponse.
    /// </summary>
    public class AlipaySocialBaseRelationCombinedQueryResponse : AopResponse
    {
        /// <summary>
        /// 复合关系数据
        /// </summary>
        [XmlArray("relation_combined_list")]
        [XmlArrayItem("relation_combined_v_o")]
        public List<RelationCombinedVO> RelationCombinedList { get; set; }
    }
}
