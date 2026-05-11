using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalImInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalImInfoSyncModel : AopObject
    {
        /// <summary>
        /// SAAS履约单ID
        /// </summary>
        [XmlElement("fulfillment_id")]
        public string FulfillmentId { get; set; }

        /// <summary>
        /// 问诊类消息列表
        /// </summary>
        [XmlElement("msg_data")]
        public MsgDataParam MsgData { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// SAAS订单ID
        /// </summary>
        [XmlElement("trade_order_id")]
        public string TradeOrderId { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
