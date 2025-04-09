using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleDeductRelationQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleDeductRelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果
        /// </summary>
        [XmlArray("deduct_list")]
        [XmlArrayItem("recycle_deduct_query_v_o")]
        public List<RecycleDeductQueryVO> DeductList { get; set; }
    }
}
