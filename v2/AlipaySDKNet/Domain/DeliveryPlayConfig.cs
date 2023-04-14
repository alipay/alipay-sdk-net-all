using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryPlayConfig Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryPlayConfig : AopObject
    {
        /// <summary>
        /// 满额送玩法投放内容配置。 限制：展位码限制为PAYMENT_REUSLT时满额生效。
        /// </summary>
        [XmlElement("delivery_full_send_config")]
        public DeliveryFullSendConfig DeliveryFullSendConfig { get; set; }

        /// <summary>
        /// 通用投放内容配置。 限制：全展位码通用。
        /// </summary>
        [XmlElement("delivery_single_send_config")]
        public DeliverySingleSendConfig DeliverySingleSendConfig { get; set; }
    }
}
