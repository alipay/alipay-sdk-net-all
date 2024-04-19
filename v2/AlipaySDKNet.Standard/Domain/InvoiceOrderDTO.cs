using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceOrderDTO : AopObject
    {
        /// <summary>
        /// 商品code
        /// </summary>
        [XmlElement("article_code")]
        public string ArticleCode { get; set; }

        /// <summary>
        /// 商品原价，单位元，最多2位小数
        /// </summary>
        [XmlElement("article_fee")]
        public string ArticleFee { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("article_id")]
        public string ArticleId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("article_name")]
        public string ArticleName { get; set; }

        /// <summary>
        /// 订购时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("buy_date")]
        public string BuyDate { get; set; }

        /// <summary>
        /// 拓展字段，json格式
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 实付总金额，单位元，最多2位小数
        /// </summary>
        [XmlElement("fact_total_fee")]
        public string FactTotalFee { get; set; }

        /// <summary>
        /// 商品规格CODE
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品规格ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品规格名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 服务市场订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订购类型，可选值： 新订购：new， 续费：renew，线下转线上：online
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }
    }
}
