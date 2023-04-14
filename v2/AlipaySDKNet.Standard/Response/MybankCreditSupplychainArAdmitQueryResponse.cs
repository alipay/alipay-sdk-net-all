using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainArAdmitQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainArAdmitQueryResponse : AopResponse
    {
        /// <summary>
        /// 准入/不准入：true/false
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 不准入说明
        /// </summary>
        [XmlElement("context")]
        public string Context { get; set; }
    }
}
