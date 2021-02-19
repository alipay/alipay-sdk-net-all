using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthorizeDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AuthorizeDetailDTO : AopObject
    {
        /// <summary>
        /// 收单主体PID
        /// </summary>
        [XmlElement("authorized_principal_id")]
        public string AuthorizedPrincipalId { get; set; }
    }
}
