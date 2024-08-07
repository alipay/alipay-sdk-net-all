using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitDeviceInfo : AopObject
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("apd_id")]
        public string ApdId { get; set; }

        /// <summary>
        /// 钱包版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 手机品牌，非固定值
        /// </summary>
        [XmlElement("mobile_brand")]
        public string MobileBrand { get; set; }

        /// <summary>
        /// 手机机型
        /// </summary>
        [XmlElement("mobile_model")]
        public string MobileModel { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [XmlElement("os_type")]
        public string OsType { get; set; }

        /// <summary>
        /// 屏幕高，单位：px
        /// </summary>
        [XmlElement("screen_height")]
        public string ScreenHeight { get; set; }

        /// <summary>
        /// 屏幕宽，单位：px
        /// </summary>
        [XmlElement("screen_width")]
        public string ScreenWidth { get; set; }

        /// <summary>
        /// 操作系统类型
        /// </summary>
        [XmlElement("system_type")]
        public string SystemType { get; set; }

        /// <summary>
        /// 操作系统版本
        /// </summary>
        [XmlElement("system_version")]
        public string SystemVersion { get; set; }

        /// <summary>
        /// 无线设备统一ID方案
        /// </summary>
        [XmlElement("utd_id")]
        public string UtdId { get; set; }
    }
}
