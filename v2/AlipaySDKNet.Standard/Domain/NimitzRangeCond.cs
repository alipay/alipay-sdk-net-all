using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NimitzRangeCond Data Structure.
    /// </summary>
    [Serializable]
    public class NimitzRangeCond : AopObject
    {
        /// <summary>
        /// 范围条件key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 范围条件value
        /// </summary>
        [XmlElement("range")]
        public NimitzRange Range { get; set; }
    }
}
