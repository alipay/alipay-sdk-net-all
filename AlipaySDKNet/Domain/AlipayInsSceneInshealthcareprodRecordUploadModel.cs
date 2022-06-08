using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthcareprodRecordUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInshealthcareprodRecordUploadModel : AopObject
    {
        /// <summary>
        /// 小区号(16 进制字符串)
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 设备电量
        /// </summary>
        [XmlElement("device_battery")]
        public string DeviceBattery { get; set; }

        /// <summary>
        /// 设备SN码，唯一，用于唯一确定设备
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备用户，非唯一，用于区分设备的用户。 单用户设备(血糖仪、呼吸机)恒为 0000；多用户设备(血压计)中 A 用户为 0000；B 用户为 0001
        /// </summary>
        [XmlElement("device_user")]
        public string DeviceUser { get; set; }

        /// <summary>
        /// 基站号(16 进制字符串)
        /// </summary>
        [XmlElement("lac")]
        public string Lac { get; set; }

        /// <summary>
        /// 测量点：0 餐前; 1 餐后; 3 随机
        /// </summary>
        [XmlElement("meal")]
        public string Meal { get; set; }

        /// <summary>
        /// 测量时间，注意需要按照特定的时间格式。 yyyy-mm-dd  hh:mm:ss
        /// </summary>
        [XmlElement("measure_time")]
        public string MeasureTime { get; set; }

        /// <summary>
        /// 测量值，非唯一，表示测量得到的数据
        /// </summary>
        [XmlElement("measure_value")]
        public string MeasureValue { get; set; }

        /// <summary>
        /// 移动基站 0，联通基站 1
        /// </summary>
        [XmlElement("mnc")]
        public string Mnc { get; set; }
    }
}
