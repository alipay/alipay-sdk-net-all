using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAuthTokenGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAuthTokenGetModel : AopObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 履约单ID
        /// </summary>
        [XmlElement("fulfillment_id")]
        public string FulfillmentId { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// SAAS订单ID
        /// </summary>
        [XmlElement("trade_order_id")]
        public string TradeOrderId { get; set; }
    }
}
