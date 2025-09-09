using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeGiftStatusSyncResponse.
    /// </summary>
    public class AlipayTradeGiftStatusSyncResponse : AopResponse
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("recipient_open_id")]
        public string RecipientOpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("recipient_user_id")]
        public string RecipientUserId { get; set; }

        /// <summary>
        /// 关联订单组id,一送多收的场景
        /// </summary>
        [XmlElement("tb_og_id")]
        public string TbOgId { get; set; }

        /// <summary>
        /// 淘宝订单id
        /// </summary>
        [XmlElement("tb_order_id")]
        public string TbOrderId { get; set; }
    }
}
