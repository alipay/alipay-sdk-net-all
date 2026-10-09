using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryFullSendConfig Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryFullSendConfig : AopObject
    {
        /// <summary>
        /// 投放展位的投放内容。
        /// </summary>
        [XmlElement("delivery_content_info")]
        public DeliveryContentInfo DeliveryContentInfo { get; set; }

        /// <summary>
        /// 满足消费金额门槛，左闭区间，单位元。 说明：限制支付时的订单金额最少满足的金额门槛。 限制：value > 0 && value <= 99999。
        /// </summary>
        [XmlElement("delivery_floor_amount")]
        public string DeliveryFloorAmount { get; set; }
    }
}
