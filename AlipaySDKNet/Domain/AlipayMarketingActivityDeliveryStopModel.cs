using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityDeliveryStopModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityDeliveryStopModel : AopObject
    {
        /// <summary>
        /// 当前服务商所代理的商户信息. 在停止投放时，会使用商户信息来进行权限判断. 如果代理商户信息中的businessType为ISV模式.则默认使用当前操作人的信息作为商户信息
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public DeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 待停止的投放配置列表。 最大数量限制20个。
        /// </summary>
        [XmlArray("delivery_config_list")]
        [XmlArrayItem("delivery_config")]
        public List<DeliveryConfig> DeliveryConfigList { get; set; }
    }
}
