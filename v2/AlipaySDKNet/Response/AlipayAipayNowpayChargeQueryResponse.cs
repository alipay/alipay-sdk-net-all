using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayNowpayChargeQueryResponse.
    /// </summary>
    public class AlipayAipayNowpayChargeQueryResponse : AopResponse
    {
        /// <summary>
        /// 最终收费模式
        /// </summary>
        [XmlElement("billing_mode")]
        public string BillingMode { get; set; }

        /// <summary>
        /// 商品状态
        /// </summary>
        [XmlElement("capability_status")]
        public string CapabilityStatus { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("charging_options")]
        [XmlArrayItem("charging_option")]
        public List<ChargingOption> ChargingOptions { get; set; }

        /// <summary>
        /// 平台直接使用该地址进入商品管理
        /// </summary>
        [XmlElement("management_url")]
        public string ManagementUrl { get; set; }

        /// <summary>
        /// 商品图标
        /// </summary>
        [XmlElement("product_icon_url")]
        public string ProductIconUrl { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 额度包返回
        /// </summary>
        [XmlElement("quota_unit")]
        public string QuotaUnit { get; set; }

        /// <summary>
        /// 签约结果展示说明
        /// </summary>
        [XmlElement("reason_message")]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// 状态版本
        /// </summary>
        [XmlElement("status_version")]
        public string StatusVersion { get; set; }
    }
}
