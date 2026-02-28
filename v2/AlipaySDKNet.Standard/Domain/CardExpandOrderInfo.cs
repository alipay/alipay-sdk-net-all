using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardExpandOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardExpandOrderInfo : AopObject
    {
        /// <summary>
        /// 延期单id
        /// </summary>
        [XmlElement("card_expand_order_id")]
        public string CardExpandOrderId { get; set; }

        /// <summary>
        /// CUSTOMER_CONFIRMING("CUSTOMER_CONFIRMING：待购卡用户确认   CUSTOMER_REJECT("CUSTOMER_REJECT：购卡用户拒绝延期   INVALID("INVALID：延期单失效   SUCCESS("SUCCESS：延期成功
        /// </summary>
        [XmlElement("card_expand_order_status")]
        public string CardExpandOrderStatus { get; set; }

        /// <summary>
        /// 安心付卡id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 延期单购卡用户超时时间，超时后系统自动确认
        /// </summary>
        [XmlElement("customer_confirm_timeout")]
        public string CustomerConfirmTimeout { get; set; }

        /// <summary>
        /// 延期后新的过期时间
        /// </summary>
        [XmlElement("expand_expire_date")]
        public string ExpandExpireDate { get; set; }

        /// <summary>
        /// 延期原因
        /// </summary>
        [XmlElement("expand_reason")]
        public string ExpandReason { get; set; }

        /// <summary>
        /// 购买用户拒绝延期原因
        /// </summary>
        [XmlElement("expand_reject_reason")]
        public string ExpandRejectReason { get; set; }

        /// <summary>
        /// 延期前的过期时间
        /// </summary>
        [XmlElement("original_expire_date")]
        public string OriginalExpireDate { get; set; }
    }
}
