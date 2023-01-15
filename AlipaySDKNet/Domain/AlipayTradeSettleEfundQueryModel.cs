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
        /// 卖家userId，支付宝userId
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
