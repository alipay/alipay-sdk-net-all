using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfleadsmemberDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfleadsmemberDeleteModel : AopObject
    {
        /// <summary>
        /// 提供给SalesForce删除项目组成员入参
        /// </summary>
        [XmlElement("salesforce_delete_leads_member_request")]
        public SaleForceLeadsMemberDeleteDTO SalesforceDeleteLeadsMemberRequest { get; set; }
    }
}
