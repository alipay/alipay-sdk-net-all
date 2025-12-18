using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryCustomerAndLeadsByUidRequest Data Structure.
    /// </summary>
    [Serializable]
    public class QueryCustomerAndLeadsByUidRequest : AopObject
    {
        /// <summary>
        /// 官网uid
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 渠道uid
        /// </summary>
        [XmlElement("platform_uid")]
        public string PlatformUid { get; set; }
    }
}
