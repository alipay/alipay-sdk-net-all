using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalAppSceneMsgSendArg Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalAppSceneMsgSendArg : AopObject
    {
        /// <summary>
        /// 键
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
