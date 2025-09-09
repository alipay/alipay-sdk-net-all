using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NDeliveryPalyConfig Data Structure.
    /// </summary>
    [Serializable]
    public class NDeliveryPalyConfig : AopObject
    {
        /// <summary>
        /// 碰一下支付成功页展示的卡片内容
        /// </summary>
        [XmlElement("n_delivery_content_info")]
        public NDeliveryContentInfo NDeliveryContentInfo { get; set; }

        /// <summary>
        /// 枚举值： ·支付即送（任意支付均可，无订单金额限制）
        /// </summary>
        [XmlElement("n_delivery_send_mode")]
        public string NDeliverySendMode { get; set; }
    }
}
