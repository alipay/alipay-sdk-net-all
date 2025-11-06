using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsClaimOverdueBizData Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimOverdueBizData : AopObject
    {
        /// <summary>
        /// 买家手机号
        /// </summary>
        [XmlElement("buyer_phone")]
        public string BuyerPhone { get; set; }

        /// <summary>
        /// 当前游戏账户绑定手机号
        /// </summary>
        [XmlElement("game_account_phone")]
        public string GameAccountPhone { get; set; }

        /// <summary>
        /// 追偿账单标题
        /// </summary>
        [XmlElement("overdue_bill_title")]
        public string OverdueBillTitle { get; set; }

        /// <summary>
        /// 卖家手机号
        /// </summary>
        [XmlElement("seller_phone")]
        public string SellerPhone { get; set; }
    }
}
