using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferCredential Data Structure.
    /// </summary>
    [Serializable]
    public class TransferCredential : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("credential_no")]
        public string CredentialNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("credential_type")]
        public string CredentialType { get; set; }
    }
}
