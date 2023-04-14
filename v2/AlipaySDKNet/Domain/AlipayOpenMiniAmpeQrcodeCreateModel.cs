using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeQrcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeQrcodeCreateModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 硬件设备的在AMPE注册的设备id，可以通过jsapi-my.getSystemInfo获取，对应的属性名为：arome_deviceId
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 需要跳转的小程序appId
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 需要跳转的页面，默认为首页
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 硬件设备的在AMPE注册的产品id，可以通过jsapi-my.getSystemInfo获取，对应的属性名为：arome_productId
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 需要跳转页面携带的
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }
    }
}
