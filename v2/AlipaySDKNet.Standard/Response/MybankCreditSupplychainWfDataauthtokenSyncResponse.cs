using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainWfDataauthtokenSyncResponse.
    /// </summary>
    public class MybankCreditSupplychainWfDataauthtokenSyncResponse : AopResponse
    {
        /// <summary>
        /// 请求受理成功与否
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
