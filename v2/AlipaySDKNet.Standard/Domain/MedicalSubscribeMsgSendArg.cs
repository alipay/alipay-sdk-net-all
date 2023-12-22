using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalSubscribeMsgSendArg Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalSubscribeMsgSendArg : AopObject
    {
        /// <summary>
        /// 消息模板中参数的一个参数的键
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 消息模板中参数的一个参数的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
