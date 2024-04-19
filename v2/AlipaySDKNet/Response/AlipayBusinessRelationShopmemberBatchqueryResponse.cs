using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopmemberBatchqueryResponse.
    /// </summary>
    public class AlipayBusinessRelationShopmemberBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果
        /// </summary>
        [XmlArray("members")]
        [XmlArrayItem("business_relation_shop_member_digest")]
        public List<BusinessRelationShopMemberDigest> Members { get; set; }
    }
}
