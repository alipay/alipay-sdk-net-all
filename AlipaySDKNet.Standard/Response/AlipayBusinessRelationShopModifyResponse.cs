using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopModifyResponse.
    /// </summary>
    public class AlipayBusinessRelationShopModifyResponse : AopResponse
    {
        /// <summary>
        /// 基于商业关系的代运营门店id
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }
    }
}
