using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainWfLockaccountsyncQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainWfLockaccountsyncQueryModel : AopObject
    {
        /// <summary>
        /// 锁户同步
        /// </summary>
        [XmlArray("lockaccountsyncs")]
        [XmlArrayItem("lockaccountsync")]
        public List<Lockaccountsync> Lockaccountsyncs { get; set; }

        /// <summary>
        /// 幂等id
        /// </summary>
        [XmlElement("requestid")]
        public string Requestid { get; set; }
    }
}
