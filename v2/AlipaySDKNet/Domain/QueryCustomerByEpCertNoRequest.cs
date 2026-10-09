using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryCustomerByEpCertNoRequest Data Structure.
    /// </summary>
    [Serializable]
    public class QueryCustomerByEpCertNoRequest : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ep_cert_no_list")]
        [XmlArrayItem("string")]
        public List<string> EpCertNoList { get; set; }
    }
}
