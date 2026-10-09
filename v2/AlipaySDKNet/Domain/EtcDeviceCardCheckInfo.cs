using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcDeviceCardCheckInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EtcDeviceCardCheckInfo : AopObject
    {
        /// <summary>
        /// 具体错误信息描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 错误处理方法
        /// </summary>
        [XmlElement("error_handler")]
        public string ErrorHandler { get; set; }

        /// <summary>
        /// 设备异常类型
        /// </summary>
        [XmlElement("error_type")]
        public string ErrorType { get; set; }
    }
}
