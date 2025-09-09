using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JhjtestDoc Data Structure.
    /// </summary>
    [Serializable]
    public class JhjtestDoc : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a_open_id")]
        public long AOpenId { get; set; }

        /// <summary>
        /// 测试测试
        /// </summary>
        [XmlElement("com_a")]
        public RegressionPublic ComA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("para_a")]
        public long ParaA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("para_b")]
        public string ParaB { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("para_c")]
        public string ParaC { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("para_d")]
        public string ParaD { get; set; }
    }
}
