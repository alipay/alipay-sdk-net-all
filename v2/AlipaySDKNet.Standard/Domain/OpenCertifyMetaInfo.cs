using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenCertifyMetaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenCertifyMetaInfo : AopObject
    {
        /// <summary>
        /// 设备操作系统类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }
    }
}
