using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperationResultExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OperationResultExtInfo : AopObject
    {
        /// <summary>
        /// 激活时间
        /// </summary>
        [XmlElement("activation_time")]
        public string ActivationTime { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }
    }
}
