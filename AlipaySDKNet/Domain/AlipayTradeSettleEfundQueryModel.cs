using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSettleEfundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSettleEfundQueryModel : AopObject
    {
        /// <summary>
        /// 卖家openId
        /// </summary>
        [XmlElement("seller_open_id")]
        public string SellerOpenId { get; set; }

        /// <summary>
        /// 卖家userId
        /// </summary>
        [XmlElement("seller_user_id")]
        public string SellerUserId { get; set; }

        /// <summary>
        /// 管控资金业务类型
        /// </summary>
        [XmlElement("settle_biz_type")]
        public string SettleBizType { get; set; }
    }
}
