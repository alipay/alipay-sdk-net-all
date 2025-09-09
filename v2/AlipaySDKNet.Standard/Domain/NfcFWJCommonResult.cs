using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcFWJCommonResult Data Structure.
    /// </summary>
    [Serializable]
    public class NfcFWJCommonResult : AopObject
    {
        /// <summary>
        /// NFC烧录URL
        /// </summary>
        [XmlElement("scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// 授权码
        /// </summary>
        [XmlElement("uni_code")]
        public string UniCode { get; set; }
    }
}
