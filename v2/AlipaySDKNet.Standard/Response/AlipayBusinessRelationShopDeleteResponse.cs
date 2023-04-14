using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopDeleteResponse.
    /// </summary>
    public class AlipayBusinessRelationShopDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除的商业关系门店id
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }
    }
}
