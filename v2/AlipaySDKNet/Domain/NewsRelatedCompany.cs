using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsRelatedCompany Data Structure.
    /// </summary>
    [Serializable]
    public class NewsRelatedCompany : AopObject
    {
        /// <summary>
        /// 公司统一社会编号
        /// </summary>
        [XmlElement("org_cert_no")]
        public string OrgCertNo { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }
    }
}
