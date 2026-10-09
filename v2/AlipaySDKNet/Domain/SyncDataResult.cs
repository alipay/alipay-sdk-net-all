using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SyncDataResult Data Structure.
    /// </summary>
    [Serializable]
    public class SyncDataResult : AopObject
    {
        /// <summary>
        /// 数据同步结果键
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 数据同步结果值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
