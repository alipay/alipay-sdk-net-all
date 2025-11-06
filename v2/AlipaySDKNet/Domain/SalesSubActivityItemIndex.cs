using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SalesSubActivityItemIndex Data Structure.
    /// </summary>
    [Serializable]
    public class SalesSubActivityItemIndex : AopObject
    {
        /// <summary>
        /// 指标key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 统计结果
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
