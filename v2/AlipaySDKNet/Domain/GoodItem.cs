using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodItem Data Structure.
    /// </summary>
    [Serializable]
    public class GoodItem : AopObject
    {
        /// <summary>
        /// 商品可用的城市列表
        /// </summary>
        [XmlArray("available_city_list")]
        [XmlArrayItem("string")]
        public List<string> AvailableCityList { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 商品不同级类目之间用$##$分隔，且自左向右类目层级逐渐细化。类目值搜索全部传名称，举例如“家电$##$电视$##$OLED电视”。某一段为空时直接传空字符串，如第二段为空， 则传“家电$##$$##$OLED电视”。如果有多个类目，多个类目之间用,分割。
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
        /// 商品描述
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 商品现价
        /// </summary>
        [XmlElement("current_price")]
        public string CurrentPrice { get; set; }

        /// <summary>
        /// 非负数。保留两位小数。币种默认CNY。
        /// </summary>
        [XmlElement("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 商品图片数量
        /// </summary>
        [XmlElement("detail_pic_num")]
        public long DetailPicNum { get; set; }

        /// <summary>
        /// 支付宝小程序的商品详情页面
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 未定义在标准字段内的字段，可以通过扩展json字段进行同步
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 租赁商品的新日描述
        /// </summary>
        [XmlElement("fresh_degree")]
        public string FreshDegree { get; set; }

        /// <summary>
        /// 用户在小程序前端感知的类目值
        /// </summary>
        [XmlElement("front_end_category")]
        public string FrontEndCategory { get; set; }

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
        /// 商品的logo图片列表，可用于用户展示的图片，建议600*600
        /// </summary>
        [XmlArray("promo_pic_url_list")]
        [XmlArrayItem("string")]
        public List<string> PromoPicUrlList { get; set; }

        /// <summary>
        /// 商品上架时间戳，精确到秒，如1520327038
        /// </summary>
        [XmlElement("pub_time")]
        public long PubTime { get; set; }

        /// <summary>
        /// 商品评分
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
        /// 物品类型
        /// </summary>
        [XmlElement("row_type")]
        public string RowType { get; set; }

        /// <summary>
        /// 商品支持自提：1：支持 2：不支持 3：满足条件支持
        /// </summary>
        [XmlElement("self_pickup")]
        public string SelfPickup { get; set; }

        /// <summary>
        /// 百分比，值范国0.00%-100.00%，保留两位小数
        /// </summary>
        [XmlElement("shipment_rate")]
        public string ShipmentRate { get; set; }

        /// <summary>
        /// 商品支持的发货城市列表
        /// </summary>
        [XmlElement("shipments")]
        public string Shipments { get; set; }

        /// <summary>
        /// 商品所属店铺id（如有）
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商品所在店铺对应的店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

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
        /// 库存数量，库存数量为0的商品不会出现在搜索结果里面
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 非负数，保留两位小数，值范国0.00-5.00分
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
