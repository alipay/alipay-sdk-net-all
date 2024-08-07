using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePetinsureEffectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePetinsureEffectModel : AopObject
    {
        /// <summary>
        /// 外部业务单号，每一笔新的投保请求应该保持唯一。
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 买家用户Id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家openId
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 宠物售价，单位分
        /// </summary>
        [XmlElement("item_sale_price")]
        public long ItemSalePrice { get; set; }

        /// <summary>
        /// 支付宝宠物Id
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }

        /// <summary>
        /// 报价流水Id
        /// </summary>
        [XmlElement("quote_id")]
        public string QuoteId { get; set; }

        /// <summary>
        /// 推荐流水Id
        /// </summary>
        [XmlElement("recommend_flow_id")]
        public string RecommendFlowId { get; set; }
    }
}
