using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GuardrailsBiz Data Structure.
    /// </summary>
    [Serializable]
    public class GuardrailsBiz : AopObject
    {
        /// <summary>
        /// 护栏业务编码
        /// </summary>
        [XmlElement("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 护栏业务文案
        /// </summary>
        [XmlElement("business_msg")]
        public string BusinessMsg { get; set; }
    }
}
