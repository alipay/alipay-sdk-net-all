using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneMarketingEquitycodeDiscryptGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneMarketingEquitycodeDiscryptGetModel : AopObject
    {
        /// <summary>
        /// 加密后的券码
        /// </summary>
        [XmlElement("encrypted_code")]
        public string EncryptedCode { get; set; }

        /// <summary>
        /// 来源，每个接入的第三方都会有一个来源号
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
