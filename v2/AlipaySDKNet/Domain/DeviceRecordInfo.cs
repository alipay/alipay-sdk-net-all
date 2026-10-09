using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceRecordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceRecordInfo : AopObject
    {
        /// <summary>
        /// 设备绑定的时候传的账户类型
        /// </summary>
        [XmlElement("records_type")]
        public string RecordsType { get; set; }

        /// <summary>
        /// 与records_type对应的参数值。 如直连商家 PID：2088101156429885
        /// </summary>
        [XmlElement("records_value")]
        public string RecordsValue { get; set; }
    }
}
