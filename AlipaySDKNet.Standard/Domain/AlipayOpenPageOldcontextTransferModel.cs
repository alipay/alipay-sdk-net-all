using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPageOldcontextTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPageOldcontextTransferModel : AopObject
    {
        /// <summary>
        /// 参数1
        /// </summary>
        [XmlElement("param_one")]
        public string ParamOne { get; set; }

        /// <summary>
        /// 参数3
        /// </summary>
        [XmlElement("param_three")]
        public string ParamThree { get; set; }

        /// <summary>
        /// 参数2
        /// </summary>
        [XmlElement("param_two")]
        public string ParamTwo { get; set; }
    }
}
