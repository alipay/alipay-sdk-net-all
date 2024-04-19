using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IoTBPaaSKeyValue Data Structure.
    /// </summary>
    [Serializable]
    public class IoTBPaaSKeyValue : AopObject
    {
        /// <summary>
        /// 参数名key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数值value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
