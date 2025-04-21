using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityVoiceprintUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskVerifyidentityVoiceprintUploadModel : AopObject
    {
        /// <summary>
        /// 数据类型描述
        /// </summary>
        [XmlElement("data_type_name")]
        public string DataTypeName { get; set; }

        /// <summary>
        /// 设备唯一id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备当前信息
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 设备版本
        /// </summary>
        [XmlElement("device_version")]
        public string DeviceVersion { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }
    }
}
