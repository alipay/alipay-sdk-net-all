using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcShopgroupCreateResponse.
    /// </summary>
    public class AlipayCommerceEcShopgroupCreateResponse : AopResponse
    {
        /// <summary>
        /// 门店组包含的门店数量
        /// </summary>
        [XmlElement("shop_cnt")]
        public string ShopCnt { get; set; }

        /// <summary>
        /// 门店组ID
        /// </summary>
        [XmlElement("shop_group_id")]
        public string ShopGroupId { get; set; }
    }
}
