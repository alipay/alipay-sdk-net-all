using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategoryQueryResponse.
    /// </summary>
    public class KoubeiCateringDishVirtualcategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否需要重试，true：需要；false：不需要
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 门店下虚拟类目信息
        /// </summary>
        [XmlElement("shop_info")]
        public KbdishVirtualShopSimplifyInfo ShopInfo { get; set; }
    }
}
