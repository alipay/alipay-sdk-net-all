using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryMiniAppContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryMiniAppContentInfo : AopObject
    {
        /// <summary>
        /// 仅小程序推广可用。枚举值：服务直达
        /// </summary>
        [XmlElement("mini_app_delivery_type")]
        public string MiniAppDeliveryType { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序服务编码/home_page，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。 限制: 1.只有mini_app_id有值时该值传入才会有效 2.当前只支持一个服务code 3.service_codes必须是已传入的mini_app_id下的小程序
        /// </summary>
        [XmlArray("service_code_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceCodeList { get; set; }
    }
}
