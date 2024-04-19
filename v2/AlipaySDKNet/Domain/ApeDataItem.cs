using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApeDataItem Data Structure.
    /// </summary>
    [Serializable]
    public class ApeDataItem : AopObject
    {
        /// <summary>
        /// 商品可用的城市列表
        /// </summary>
        [XmlArray("available_city_list")]
        [XmlArrayItem("string")]
        public List<string> AvailableCityList { get; set; }

        /// <summary>
        /// 商品品牌。传输品牌明文。
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
        /// 商品累计评论次数
        /// </summary>
        [XmlElement("comment_cnt")]
        public long CommentCnt { get; set; }

        /// <summary>
        /// 商品现价
        /// </summary>
        [XmlElement("current_price")]
        public string CurrentPrice { get; set; }

        /// <summary>
        /// 商品图片数量
        /// </summary>
        [XmlElement("detail_pic_num")]
        public long DetailPicNum { get; set; }

        /// <summary>
        /// 折扣优惠
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 商品是否包邮，如 1：包邮 2：不包邮 3：满足条件包邮
        /// </summary>
        [XmlElement("free_shipping")]
        public long FreeShipping { get; set; }

        /// <summary>
        /// 物品的唯一id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品归属的小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 需要公域推广，默认情况下为false 当前字段已废弃(产品升级，暂不支持商品数据进公域)
        /// </summary>
        [XmlElement("need_public_promo")]
        public bool NeedPublicPromo { get; set; }

        /// <summary>
        /// 商品原价/划线价
        /// </summary>
        [XmlElement("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 商品详情的图片列表
        /// </summary>
        [XmlArray("pic_url_list")]
        [XmlArrayItem("string")]
        public List<string> PicUrlList { get; set; }

        /// <summary>
        /// 商品累计点赞次数
        /// </summary>
        [XmlElement("praise_cnt")]
        public long PraiseCnt { get; set; }

        /// <summary>
        /// 商品的logo图片列表，建议600*600
        /// </summary>
        [XmlArray("promo_pic_url_list")]
        [XmlArrayItem("string")]
        public List<string> PromoPicUrlList { get; set; }

        /// <summary>
        /// 商品上架时间戳，精确到秒，如1520327038
        /// </summary>
        [XmlElement("pub_time")]
        public string PubTime { get; set; }

        /// <summary>
        /// 商品评分
        /// </summary>
        [XmlElement("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// 普通商品的数据类型，如果使用dataList 请使用GOODS，如果不传，默认会给你补全。
        /// </summary>
        [XmlElement("row_type")]
        public string RowType { get; set; }

        /// <summary>
        /// 商品累积销量
        /// </summary>
        [XmlElement("sale_number")]
        public long SaleNumber { get; set; }

        /// <summary>
        /// 商品累计分享次数
        /// </summary>
        [XmlElement("share_cnt")]
        public long ShareCnt { get; set; }

        /// <summary>
        /// 商品运费，单位元
        /// </summary>
        [XmlElement("shipping_money")]
        public string ShippingMoney { get; set; }

        /// <summary>
        /// 商品所属店铺id（如有）
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商品来源类型，如自营/第三方(如有)
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// spu维度的id
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 状态，1为有效、0为无效
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 库存数量，库存数量为0的商品不会出现在推荐结果里面
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 商品标签，如首页展示标签“特惠”，“热卖”,或详情页“满50包邮”,“假一赔三”等。多值示例：“特惠,热卖"
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
