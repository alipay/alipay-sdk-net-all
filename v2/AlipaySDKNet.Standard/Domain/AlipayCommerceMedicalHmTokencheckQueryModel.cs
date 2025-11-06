using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHmTokencheckQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHmTokencheckQueryModel : AopObject
    {
        /// <summary>
        /// 健管token
        /// </summary>
        [XmlElement("hm_token")]
        public string HmToken { get; set; }
    }
}
