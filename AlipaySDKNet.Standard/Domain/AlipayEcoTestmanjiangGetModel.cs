using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoTestmanjiangGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoTestmanjiangGetModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("s")]
        public string S { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }

        /// <summary>
        /// 3
        /// </summary>
        [XmlElement("x_op")]
        public string XOp { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("x_sss")]
        public string XSss { get; set; }

        /// <summary>
        /// 基础描述
        /// </summary>
        [XmlElement("x_test")]
        public string XTest { get; set; }
    }
}
