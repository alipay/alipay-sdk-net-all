using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialUserAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCommercialUserAuthModel : AopObject
    {
        /// <summary>
        /// 授权码，用户对应用授权后得到。
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }
    }
}
