using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationChangeshopBatchqueryResponse.
    /// </summary>
    public class AlipayBusinessRelationChangeshopBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商业关系异动门店信息列表
        /// </summary>
        [XmlArray("change_shop_infos")]
        [XmlArrayItem("business_relation_change_shop_info")]
        public List<BusinessRelationChangeShopInfo> ChangeShopInfos { get; set; }
    }
}
