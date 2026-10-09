using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleItemQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 回收商品，包含回收商品的款式、价格、状态等信息
        /// </summary>
        [XmlElement("recycle_item_dto")]
        public RecycleItemDTO RecycleItemDto { get; set; }
    }
}
