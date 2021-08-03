using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityDeliveryCreateResponse.
    /// </summary>
    public class AlipayMarketingActivityDeliveryCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建失败的投放信息列表  失败的投放配置列表中，会返回对应的deliveryConfig对象。
        /// </summary>
        [XmlArray("error_delivery_config_list")]
        [XmlArrayItem("error_delivery_config")]
        public List<ErrorDeliveryConfig> ErrorDeliveryConfigList { get; set; }

        /// <summary>
        /// 创建成功的投放信息列表  成功的投放配置列表中，会返回对应的deliveryConfig对象。
        /// </summary>
        [XmlArray("success_delivery_config_list")]
        [XmlArrayItem("success_delivery_config")]
        public List<SuccessDeliveryConfig> SuccessDeliveryConfigList { get; set; }
    }
}
