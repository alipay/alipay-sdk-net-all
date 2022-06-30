using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityDeliveryStopResponse.
    /// </summary>
    public class AlipayMarketingActivityDeliveryStopResponse : AopResponse
    {
        /// <summary>
        /// 推广计划id。
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// [已废弃] 停止失败的投放配置列表
        /// </summary>
        [XmlArray("error_delivery_config_list")]
        [XmlArrayItem("error_delivery_config")]
        public List<ErrorDeliveryConfig> ErrorDeliveryConfigList { get; set; }

        /// <summary>
        /// [已废弃] 停止成功的投放配置列表
        /// </summary>
        [XmlArray("success_delivery_config_list")]
        [XmlArrayItem("success_delivery_config")]
        public List<SuccessDeliveryConfig> SuccessDeliveryConfigList { get; set; }
    }
}
