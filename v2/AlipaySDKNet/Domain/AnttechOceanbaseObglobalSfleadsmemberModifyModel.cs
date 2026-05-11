using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfleadsmemberModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfleadsmemberModifyModel : AopObject
    {
        /// <summary>
        /// 提供给SalesForce更新项目组成员入参
        /// </summary>
        [XmlElement("salesforce_update_leads_member_request")]
        public SaleForceLeadsMemberModifyDTO SalesforceUpdateLeadsMemberRequest { get; set; }
    }
}
