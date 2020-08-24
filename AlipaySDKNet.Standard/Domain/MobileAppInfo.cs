using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MobileAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MobileAppInfo : AopObject
    {
        /// <summary>
        /// 移动应用绑定小程序数量
        /// </summary>
        [XmlElement("bind_mini_app_count")]
        public long BindMiniAppCount { get; set; }

        /// <summary>
        /// 移动应用id
        /// </summary>
        [XmlElement("mobile_app_id")]
        public string MobileAppId { get; set; }

        /// <summary>
        /// 移动应用名称
        /// </summary>
        [XmlElement("mobile_app_name")]
        public string MobileAppName { get; set; }

        /// <summary>
        /// 移动应用签名
        /// </summary>
        [XmlElement("mobile_app_sign")]
        public string MobileAppSign { get; set; }

        /// <summary>
        /// 设备产品信息列表
        /// </summary>
        [XmlArray("related_product_list")]
        [XmlArrayItem("device_product_info")]
        public List<DeviceProductInfo> RelatedProductList { get; set; }
    }
}
