using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NDeliveryMerchantRule Data Structure.
    /// </summary>
    [Serializable]
    public class NDeliveryMerchantRule : AopObject
    {
        /// <summary>
        /// 传入需曝光的碰一下支付成功页对应的收单账号
        /// </summary>
        [XmlArray("n_delivery_merchant_infos")]
        [XmlArrayItem("n_delivery_merchant_infos")]
        public List<NDeliveryMerchantInfos> NDeliveryMerchantInfos { get; set; }

        /// <summary>
        /// 碰一下支付成功页曝光模式。 枚举值： ·MANUAL_INPUT_SOURCE_MERCHANT：指定进件商户收单账号
        /// </summary>
        [XmlElement("n_delivery_merchant_mode")]
        public string NDeliveryMerchantMode { get; set; }
    }
}
