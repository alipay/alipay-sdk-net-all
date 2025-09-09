using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailActivityExchangeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailActivityExchangeModel : AopObject
    {
        /// <summary>
        /// 业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 活动奖品的唯一标识
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 活动唯一标识
        /// </summary>
        [XmlElement("retail_activity_id")]
        public string RetailActivityId { get; set; }

        /// <summary>
        /// 转账备注
        /// </summary>
        [XmlElement("transfer_info")]
        public string TransferInfo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
