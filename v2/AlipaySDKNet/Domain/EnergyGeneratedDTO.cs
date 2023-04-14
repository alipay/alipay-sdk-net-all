using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnergyGeneratedDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnergyGeneratedDTO : AopObject
    {
        /// <summary>
        /// 能量g数
        /// </summary>
        [XmlElement("energy")]
        public long Energy { get; set; }

        /// <summary>
        /// 环保类型
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
