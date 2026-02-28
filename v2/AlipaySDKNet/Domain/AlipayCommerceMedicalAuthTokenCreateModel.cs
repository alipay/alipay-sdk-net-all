using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAuthTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAuthTokenCreateModel : AopObject
    {
        /// <summary>
        /// 授权码，用户对应用授权后得到
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }
    }
}
