using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItapDeviceControlAction Data Structure.
    /// </summary>
    [Serializable]
    public class ItapDeviceControlAction : AopObject
    {
        /// <summary>
        /// 行为描述
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 定制控制参数
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }
    }
}
