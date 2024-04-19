using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopdetailQueryResponse.
    /// </summary>
    public class AlipayBusinessRelationShopdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店详情信息
        /// </summary>
        [XmlElement("shop_info")]
        public BusinessRelationShopDetailInfo ShopInfo { get; set; }
    }
}
