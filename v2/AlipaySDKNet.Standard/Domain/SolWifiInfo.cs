using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SolWifiInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SolWifiInfo : AopObject
    {
        /// <summary>
        /// 1：WIFI类型是账密模式时，此值无效，可不传； 2：WIFI类型是Portal模式时，新增必传； 3：修改可不传，不传不改；
        /// </summary>
        [XmlElement("cert_url")]
        public string CertUrl { get; set; }

        /// <summary>
        /// 启用ENABLE、禁用DISABLE
        /// </summary>
        [XmlElement("enable_flag")]
        public string EnableFlag { get; set; }

        /// <summary>
        /// WIFI链接成功之后跳转的目标地址
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 点位ID(场所ID)值
        /// </summary>
        [XmlElement("location_id")]
        public string LocationId { get; set; }

        /// <summary>
        /// 场所名称； 1：新增必传； 2：修改可不传，不传不改；
        /// </summary>
        [XmlElement("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 1：WIFI类型是账密模式时，此值无效，可不传； 2：WIFI类型是Portal模式时，新增必传； 3：修改可不传，不传不改；
        /// </summary>
        [XmlElement("sms_cert_url")]
        public string SmsCertUrl { get; set; }

        /// <summary>
        /// 1：WIFI类型是Portal模式时,新增必传； 2：WIFI类型是账密模式时，此值无效，可不传； 3：修改可不传，不传不改；
        /// </summary>
        [XmlElement("spi_client_id")]
        public string SpiClientId { get; set; }

        /// <summary>
        /// 1：WIFI类型是Portal模式时，新增必传； 2：账密模式，此值无效，可不传； 3：修改可不传，不传不改
        /// </summary>
        [XmlElement("wifi_bssid")]
        public string WifiBssid { get; set; }

        /// <summary>
        /// 1：WIFI类型是账密模式时，新增必传； 2：WIFI类型是Portal模式时，此值无效，可不传； 3：修改可不传，不传不改；
        /// </summary>
        [XmlElement("wifi_cipher")]
        public string WifiCipher { get; set; }

        /// <summary>
        /// 1：新增可不传； 2：修改必传；
        /// </summary>
        [XmlElement("wifi_id")]
        public string WifiId { get; set; }

        /// <summary>
        /// 1：新增必传； 2：修改可不传，不传不修改
        /// </summary>
        [XmlElement("wifi_name")]
        public string WifiName { get; set; }

        /// <summary>
        /// 1：新增必传； 2：修改可不传，不支持变更，比如：账密改Portal
        /// </summary>
        [XmlElement("wifi_type")]
        public string WifiType { get; set; }
    }
}
