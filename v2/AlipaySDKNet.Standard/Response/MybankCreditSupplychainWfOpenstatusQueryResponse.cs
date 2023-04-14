using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainWfOpenstatusQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainWfOpenstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 开通状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
