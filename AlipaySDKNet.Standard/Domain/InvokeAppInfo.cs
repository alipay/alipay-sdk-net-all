using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvokeAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvokeAppInfo : AopObject
    {
        /// <summary>
        /// 调用应用id
        /// </summary>
        [XmlElement("invoke_app_id")]
        public string InvokeAppId { get; set; }

        /// <summary>
        /// 调用应用logo
        /// </summary>
        [XmlElement("invoke_app_logo")]
        public string InvokeAppLogo { get; set; }

        /// <summary>
        /// 调用应用名称
        /// </summary>
        [XmlElement("invoke_app_name")]
        public string InvokeAppName { get; set; }

        /// <summary>
        /// 设备产品列表信息
        /// </summary>
        [XmlArray("related_product_list")]
        [XmlArrayItem("device_product_info")]
        public List<DeviceProductInfo> RelatedProductList { get; set; }
    }
}
