using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailItemQueryResponse.
    /// </summary>
    public class KoubeiRetailItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 封面图url地址
        /// </summary>
        [XmlElement("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlArray("descriptions")]
        [XmlArrayItem("retail_item_description")]
        public List<RetailItemDescription> Descriptions { get; set; }

        /// <summary>
        /// 折扣比例，5折：0.5
        /// </summary>
        [XmlElement("discount_rate")]
        public string DiscountRate { get; set; }

        /// <summary>
        /// 商品失效时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 商品生效时间
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品状态，共有5个状态：INIT（初始状态）EFFECTIVE（生效）PAUSE（暂停）FREEZE(冻结)INVALID（失效）
        /// </summary>
        [XmlElement("item_status")]
        public string ItemStatus { get; set; }

        /// <summary>
        /// 商品原价(减至券)。单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("original_amount")]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// 商品详情图片列表
        /// </summary>
        [XmlArray("picture_list")]
        [XmlArrayItem("string")]
        public List<string> PictureList { get; set; }

        /// <summary>
        /// 优惠价(减至券)。单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("reduce_to_amount")]
        public string ReduceToAmount { get; set; }

        /// <summary>
        /// 商品适用的门店信息列表
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("string")]
        public List<string> ShopList { get; set; }

        /// <summary>
        /// 适用的sku列表,最多支持800个SKU，超过返回为空
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("string")]
        public List<string> SkuList { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 券类型：CASH为代金券，DISCOUNT为折扣券;ALL为全场，SINGLE为单品
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 代金券金额：满100减30 => 30。单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("value_amount")]
        public string ValueAmount { get; set; }
    }
}
