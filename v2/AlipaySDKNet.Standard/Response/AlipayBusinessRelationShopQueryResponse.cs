using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopQueryResponse.
    /// </summary>
    public class AlipayBusinessRelationShopQueryResponse : AopResponse
    {
        /// <summary>
        /// 代运营商业关系门店信息
        /// </summary>
        [XmlArray("shop_infos")]
        [XmlArrayItem("business_relation_shop_info")]
        public List<BusinessRelationShopInfo> ShopInfos { get; set; }
    }
}
