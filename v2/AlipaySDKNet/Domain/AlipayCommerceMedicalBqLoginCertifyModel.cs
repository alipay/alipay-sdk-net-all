using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalBqLoginCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalBqLoginCertifyModel : AopObject
    {
        /// <summary>
        /// 原始authCode使用Base64编码后的结果 
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }
    }
}
