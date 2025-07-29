using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainysCompelxTypeWeakRefTwo Data Structure.
    /// </summary>
    [Serializable]
    public class RainysCompelxTypeWeakRefTwo : AopObject
    {
        /// <summary>
        /// case
        /// </summary>
        [XmlElement("demo_weak_empty")]
        public string DemoWeakEmpty { get; set; }

        /// <summary>
        /// case
        /// </summary>
        [XmlElement("demo_weak_value")]
        public string DemoWeakValue { get; set; }
    }
}
