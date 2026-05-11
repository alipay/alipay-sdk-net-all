using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfleadsmemberCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfleadsmemberCreateModel : AopObject
    {
        /// <summary>
        /// 提供给SalesForce创建项目组成员入参
        /// </summary>
        [XmlElement("salesforce_create_leads_member_request")]
        public SaleForceLeadsMemberCreateDTO SalesforceCreateLeadsMemberRequest { get; set; }
    }
}
