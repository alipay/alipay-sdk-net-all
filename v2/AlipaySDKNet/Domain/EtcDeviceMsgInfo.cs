using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcDeviceMsgInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EtcDeviceMsgInfo : AopObject
    {
        /// <summary>
        /// ETC设备激活状态
        /// </summary>
        [XmlElement("active_status")]
        public string ActiveStatus { get; set; }

        /// <summary>
        /// 电量百分比数值
        /// </summary>
        [XmlElement("battery_percent")]
        public long BatteryPercent { get; set; }

        /// <summary>
        /// 设备BIOS系统版本号
        /// </summary>
        [XmlElement("bios_version")]
        public string BiosVersion { get; set; }

        /// <summary>
        /// 业务触发时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// ETC卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 1234584849
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 设备检测状态
        /// </summary>
        [XmlElement("device_status")]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// 设备固件版本号
        /// </summary>
        [XmlElement("device_version")]
        public string DeviceVersion { get; set; }

        /// <summary>
        /// 错误信息列表
        /// </summary>
        [XmlArray("error_list")]
        [XmlArrayItem("etc_device_card_check_info")]
        public List<EtcDeviceCardCheckInfo> ErrorList { get; set; }

        /// <summary>
        /// ETC开关状态
        /// </summary>
        [XmlElement("etc_switch_status")]
        public string EtcSwitchStatus { get; set; }

        /// <summary>
        /// 4G信号强度百分比数值
        /// </summary>
        [XmlElement("fourth_generation_signal_percent")]
        public long FourthGenerationSignalPercent { get; set; }

        /// <summary>
        /// GPS信号强度百分比数值
        /// </summary>
        [XmlElement("gps_signal_percent")]
        public long GpsSignalPercent { get; set; }

        /// <summary>
        /// 关闭多少秒后自动打开
        /// </summary>
        [XmlElement("interval")]
        public long Interval { get; set; }

        /// <summary>
        /// 设备商品sku码，可区分同类设备
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// 设备语音开关状态
        /// </summary>
        [XmlElement("sound_status")]
        public string SoundStatus { get; set; }
    }
}
