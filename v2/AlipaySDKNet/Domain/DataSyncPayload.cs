using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataSyncPayload Data Structure.
    /// </summary>
    [Serializable]
    public class DataSyncPayload : AopObject
    {
        /// <summary>
        /// 数据同步通知模型
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 设备唯一ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
