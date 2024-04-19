using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopmemberQueryResponse.
    /// </summary>
    public class AlipayBusinessRelationShopmemberQueryResponse : AopResponse
    {
        /// <summary>
        /// 商业关系中的门店收单信息
        /// </summary>
        [XmlArray("shop_member_infos")]
        [XmlArrayItem("shop_member_info")]
        public List<ShopMemberInfo> ShopMemberInfos { get; set; }
    }
}
