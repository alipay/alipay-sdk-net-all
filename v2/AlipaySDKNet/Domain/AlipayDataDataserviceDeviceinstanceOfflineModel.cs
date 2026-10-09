using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDeviceinstanceOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDeviceinstanceOfflineModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 设备唯一编号
        /// </summary>
        [XmlElement("device_instance_id")]
        public string DeviceInstanceId { get; set; }
    }
}
