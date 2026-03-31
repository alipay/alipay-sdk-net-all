using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandChannelpoiurlModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandChannelpoiurlModifyModel : AopObject
    {
        /// <summary>
        /// 小程序url状态
        /// </summary>
        [XmlElement("app_status")]
        public string AppStatus { get; set; }

        /// <summary>
        /// 小程序服务Id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 小程序服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 门店小程序appId
        /// </summary>
        [XmlElement("shop_app_id")]
        public string ShopAppId { get; set; }

        /// <summary>
        /// 蚂蚁门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 小程序跳转url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
