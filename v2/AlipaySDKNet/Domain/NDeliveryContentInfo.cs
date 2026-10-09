using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NDeliveryContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NDeliveryContentInfo : AopObject
    {
        /// <summary>
        /// 小程序对象
        /// </summary>
        [XmlElement("n_delivery_app_content")]
        public NDeliveryAppContent NDeliveryAppContent { get; set; }

        /// <summary>
        /// 枚举值： ·MINI_APP_SERVICE：小程序服务
        /// </summary>
        [XmlElement("n_delivery_content_type")]
        public string NDeliveryContentType { get; set; }

        /// <summary>
        /// 小程序服务对客内容表达
        /// </summary>
        [XmlElement("n_delivery_display_info")]
        public NDeliveryDisplayInfo NDeliveryDisplayInfo { get; set; }
    }
}
