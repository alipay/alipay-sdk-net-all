using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountRelationQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountRelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 小荷包账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 支付宝侧唯一标识
        /// </summary>
        [XmlElement("invitee_id")]
        public string InviteeId { get; set; }

        /// <summary>
        /// 支付宝侧唯一标识
        /// </summary>
        [XmlElement("invitee_open_id")]
        public string InviteeOpenId { get; set; }

        /// <summary>
        /// 联通侧账号唯一标识
        /// </summary>
        [XmlElement("invitee_out_id")]
        public string InviteeOutId { get; set; }

        /// <summary>
        /// 支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("inviter_id")]
        public string InviterId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("inviter_open_id")]
        public string InviterOpenId { get; set; }

        /// <summary>
        /// 联通侧用户唯一标识
        /// </summary>
        [XmlElement("inviter_out_id")]
        public string InviterOutId { get; set; }

        /// <summary>
        /// 支付信息
        /// </summary>
        [XmlElement("payment_info")]
        public JAPaymentInfo PaymentInfo { get; set; }

        /// <summary>
        /// 关系绑定id
        /// </summary>
        [XmlElement("relation_id")]
        public string RelationId { get; set; }

        /// <summary>
        /// 绑定状态
        /// </summary>
        [XmlElement("relation_status")]
        public string RelationStatus { get; set; }
    }
}
