using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddShopBaseQueryResponse.
    /// </summary>
    public class AlipayOfflineSmddShopBaseQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品图展示类型，小图（SMALL）/无图（NO_PIC）
        /// </summary>
        [XmlElement("item_pic_show_type")]
        public string ItemPicShowType { get; set; }

        /// <summary>
        /// 有其仅有为 true 时表示设置了必选分类，需要引导用户设置必选分类中的商品
        /// </summary>
        [XmlElement("required_category")]
        public bool RequiredCategory { get; set; }

        /// <summary>
        /// 当商家选择了每人一份，用户访问店铺时，需要选择人数，选择人数后，自动添加 x 份商品到购物车。当商家选择每单一份，自动添加该商品到购物车。购物车需要做一些校验
        /// </summary>
        [XmlElement("required_item_type")]
        public string RequiredItemType { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("shop_address")]
        public AddressBean ShopAddress { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺公告
        /// </summary>
        [XmlElement("shop_notice")]
        public string ShopNotice { get; set; }
    }
}
