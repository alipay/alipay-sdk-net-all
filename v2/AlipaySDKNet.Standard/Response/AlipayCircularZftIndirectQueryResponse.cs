using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCircularZftIndirectQueryResponse.
    /// </summary>
    public class AlipayCircularZftIndirectQueryResponse : AopResponse
    {
        /// <summary>
        /// 进件记录
        /// </summary>
        [XmlArray("relations")]
        [XmlArrayItem("zft_indirect_relation")]
        public List<ZftIndirectRelation> Relations { get; set; }
    }
}
