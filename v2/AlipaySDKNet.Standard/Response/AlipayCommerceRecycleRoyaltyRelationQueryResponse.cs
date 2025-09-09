using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleRoyaltyRelationQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleRoyaltyRelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果
        /// </summary>
        [XmlArray("royalty_list")]
        [XmlArrayItem("recycle_royalty_query_v_o")]
        public List<RecycleRoyaltyQueryVO> RoyaltyList { get; set; }
    }
}
