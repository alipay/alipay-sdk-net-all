using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JinyouTestTwo Data Structure.
    /// </summary>
    [Serializable]
    public class JinyouTestTwo : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("t_1_openid")]
        public string T1Openid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("t_1_y")]
        public string T1Y { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("t_2_f")]
        public JinyouTestOne T2F { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("t_3_n")]
        public string T3N { get; set; }
    }
}
