using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NDeliveryTargetRule Data Structure.
    /// </summary>
    [Serializable]
    public class NDeliveryTargetRule : AopObject
    {
        /// <summary>
        /// 碰一下设备的SN，若传入则与n_delivery_merchant_rule为且关系
        /// </summary>
        [XmlElement("n_delivery_device_id")]
        public string NDeliveryDeviceId { get; set; }

        /// <summary>
        /// 曝光商户信息
        /// </summary>
        [XmlElement("n_delivery_merchant_rule")]
        public NDeliveryMerchantRule NDeliveryMerchantRule { get; set; }
    }
}
