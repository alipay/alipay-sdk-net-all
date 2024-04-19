using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GetLeadsByLeadsCodeRequest Data Structure.
    /// </summary>
    [Serializable]
    public class GetLeadsByLeadsCodeRequest : AopObject
    {
        /// <summary>
        /// 海图商机编码
        /// </summary>
        [XmlElement("leads_code")]
        public string LeadsCode { get; set; }
    }
}
