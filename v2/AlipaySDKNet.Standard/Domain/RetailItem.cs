using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RetailItem Data Structure.
    /// </summary>
    [Serializable]
    public class RetailItem : AopObject
    {
        /// <summary>
        /// 商品可售时间
        /// </summary>
        [XmlArray("available_times")]
        [XmlArrayItem("string")]
        public List<string> AvailableTimes { get; set; }

        /// <summary>
        /// 品牌名
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 支付宝小程序的商品详情页面
        /// </summary>
        [XmlElement("buy_url")]
        public string BuyUrl { get; set; }

        /// <summary>
        /// 商品不同级类目之间用$##$分隔，且自左向右类目层级逐渐细化。类目值推荐全部传名称，举例如“家电$##$电视$##$OLED电视”。某一段为空时直接传空字符串，如第二段为空， 则传“家电$##$$##$OLED电视”。如果有多个类目，多个类目之间用,分割。
        /// </summary>
        [XmlElement("cate")]
        public string Cate { get; set; }

        /// <summary>
        /// 商品类目层级数。cate_cnt必须等于len(cate.split('$##$'))，用于校验cate数据。所有商品的分类体系应该一致，即对于所有商品来说，cate_cnt应该相同
        /// </summary>
        [XmlElement("cate_cnt")]
        public long CateCnt { get; set; }

        /// <summary>
        /// 内容描述，用于搜索
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 支付宝小程序的详情页面
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 商品ID，id里面传物品id和shopId的拼接，这里传物品id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品id和shopId的拼接，拼接规则为物品id+“&”+shopId
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商户角色id，同步蚂蚁门店时的pid
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 商品归属的小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 商品详情的图片列表
        /// </summary>
        [XmlArray("pic_url_list")]
        [XmlArrayItem("string")]
        public List<string> PicUrlList { get; set; }

        /// <summary>
        /// 商品的logo图片列表，可用于用户展示的图片，建议600*600
        /// </summary>
        [XmlArray("promo_pic_url_list")]
        [XmlArrayItem("string")]
        public List<string> PromoPicUrlList { get; set; }

        /// <summary>
        /// 支付宝侧的门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 状态，1为有效、0为无效
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 商品标签，如首页展示标签“特惠”，"热卖",或详情页“满50包邮”,“假一赔三”等。多值示例："特惠,热卖"
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 标题，用于搜索
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
