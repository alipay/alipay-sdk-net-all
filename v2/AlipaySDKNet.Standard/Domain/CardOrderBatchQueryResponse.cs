using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardOrderBatchQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class CardOrderBatchQueryResponse : AopObject
    {
        /// <summary>
        /// 订购单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 订购单状态
        /// </summary>
        [XmlElement("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 剩余期数(次数)
        /// </summary>
        [XmlElement("remain_count")]
        public long RemainCount { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 总期数(次数)
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
