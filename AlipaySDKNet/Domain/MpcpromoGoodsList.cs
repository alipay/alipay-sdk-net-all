using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcpromoGoodsList Data Structure.
    /// </summary>
    [Serializable]
    public class MpcpromoGoodsList : AopObject
    {
        /// <summary>
        /// 商品可用的城市列表
        /// </summary>
        [XmlArray("available_city_list")]
        [XmlArrayItem("string")]
        public List<string> AvailableCityList { get; set; }

        /// <summary>
        /// 商品品牌名称
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 必填，若使用个性化小程序插件，则需要提供商品详情链接地址（跳转使用）
        /// </summary>
        [XmlElement("buy_url")]
        public string BuyUrl { get; set; }

        /// <summary>
        /// 商品不同级类目之间用$##$分隔，且自左向右类目层级逐渐细化。类目值推荐全部传名称，举例如“家电$##$电视$##$OLED电视”。某一段为空时直接传空字符串，如第二段为空， 则传“家电$##$$##$OLED电视”。
        /// </summary>
        [XmlElement("cate")]
        public string Cate { get; set; }

        /// <summary>
        /// 商品类目层级数。cate_cnt必须等于len(cate.split('$##$'))，用于校验cate数据。所有商品的分类体系应该一致，即对于所有商品来说，cate_cnt应该相同
        /// </summary>
        [XmlElement("cate_cnt")]
        public string CateCnt { get; set; }

        /// <summary>
        /// 正整数
        /// </summary>
        [XmlElement("comment_cnt")]
        public string CommentCnt { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 必填，非负数且保留两位小数，免费商品填写0.00
        /// </summary>
        [XmlElement("current_price")]
        public string CurrentPrice { get; set; }

        /// <summary>
        /// 币种默认CNY。非负数。保留两位小数。
        /// </summary>
        [XmlElement("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 商品详情图片数量；正整数
        /// </summary>
        [XmlElement("detail_pic_num")]
        public string DetailPicNum { get; set; }

        /// <summary>
        /// 包邮/不包邮/满足条件包邮，三选一
        /// </summary>
        [XmlElement("free_shipping")]
        public string FreeShipping { get; set; }

        /// <summary>
        /// 租赁商品的新旧描述
        /// </summary>
        [XmlElement("fresh_degree")]
        public string FreshDegree { get; set; }

        /// <summary>
        /// 物品的唯一id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品原价；非负数且保留两位小数
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
        /// 价格单位
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// 商品的logo图片列表，可用于公域推广对用户展示的图片，建议600*600
        /// </summary>
        [XmlArray("promo_pic_url_list")]
        [XmlArrayItem("string")]
        public List<string> PromoPicUrlList { get; set; }

        /// <summary>
        /// 商品上架时间，精确到秒
        /// </summary>
        [XmlElement("pub_time")]
        public string PubTime { get; set; }

        /// <summary>
        /// 满分5分
        /// </summary>
        [XmlElement("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// 商品最小租赁天数
        /// </summary>
        [XmlElement("rental_date")]
        public string RentalDate { get; set; }

        /// <summary>
        /// 商品是否支持租满即送
        /// </summary>
        [XmlElement("rental_free")]
        public string RentalFree { get; set; }

        /// <summary>
        /// 商品积累销量
        /// </summary>
        [XmlElement("sale_number")]
        public string SaleNumber { get; set; }

        /// <summary>
        /// 1：支持 2：不支持 3：满足条件支持
        /// </summary>
        [XmlElement("self_pickup")]
        public string SelfPickup { get; set; }

        /// <summary>
        /// 非负整数
        /// </summary>
        [XmlElement("share_cnt")]
        public string ShareCnt { get; set; }

        /// <summary>
        /// 百分比，值范围0.00%-100.00%，保留两位小数
        /// </summary>
        [XmlElement("shipment_rate")]
        public string ShipmentRate { get; set; }

        /// <summary>
        /// 商品支持的发货城市列表
        /// </summary>
        [XmlArray("shipments")]
        [XmlArrayItem("string")]
        public List<string> Shipments { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        [XmlElement("shipping_money")]
        public string ShippingMoney { get; set; }

        /// <summary>
        /// 商品所在店铺对应的店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商品来源类型
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 商品spu维度的id
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 推荐状态；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 库存数量为0的商品不会出现在搜索结果里面
        /// </summary>
        [XmlElement("stock_num")]
        public string StockNum { get; set; }

        /// <summary>
        /// 非负数，保留两位小数，值范围0.00-5.00分
        /// </summary>
        [XmlElement("store_rating")]
        public string StoreRating { get; set; }

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
