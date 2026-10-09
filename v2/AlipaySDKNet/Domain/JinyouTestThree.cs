using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JinyouTestThree Data Structure.
    /// </summary>
    [Serializable]
    public class JinyouTestThree : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("th_1_f")]
        public JinyouTestTwo Th1F { get; set; }

        /// <summary>
        /// 无枚举值
        /// </summary>
        [XmlElement("th_2_n")]
        public string Th2N { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("th_3_n")]
        public bool Th3N { get; set; }
    }
}
