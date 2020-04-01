using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySyncnameCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySyncnameCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务序列号
        /// </summary>
        [XmlElement("ev_seq_no")]
        public string EvSeqNo { get; set; }
    }
}
