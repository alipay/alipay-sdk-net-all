using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServiceuserAuthticketVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServiceuserAuthticketVerifyModel : AopObject
    {
        /// <summary>
        /// 授权票据
        /// </summary>
        [XmlElement("auth_ticket")]
        public string AuthTicket { get; set; }
    }
}
