using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrustSystemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrustSystemInfo : AopObject
    {
        /// <summary>
        /// 是否可调节
        /// </summary>
        [XmlElement("adjustable")]
        public bool Adjustable { get; set; }

        /// <summary>
        /// 充电系统信息
        /// </summary>
        [XmlElement("charge_system_info")]
        public ChargeSystemInfo ChargeSystemInfo { get; set; }

        /// <summary>
        /// 系统状态
        /// </summary>
        [XmlElement("system_status")]
        public string SystemStatus { get; set; }

        /// <summary>
        /// 能源系统类型
        /// </summary>
        [XmlElement("system_type")]
        public string SystemType { get; set; }
    }
}
