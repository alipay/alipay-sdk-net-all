using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NDeliveryAppContent Data Structure.
    /// </summary>
    [Serializable]
    public class NDeliveryAppContent : AopObject
    {
        /// <summary>
        /// 小程序appid
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序服务id，通过  alipay.open.app.service.apply(服务提报申请) 接口创建服务后获取。 限制:  1.只有mini_app_id有值时该值传入才会有效； 2.当前只支持一个sercive_code； 3.service_code必须是已传入的mini_app_id下的小程序服务；
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
