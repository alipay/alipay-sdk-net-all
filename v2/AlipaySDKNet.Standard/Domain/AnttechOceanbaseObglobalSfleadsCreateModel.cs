using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfleadsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfleadsCreateModel : AopObject
    {
        /// <summary>
        /// 提供给saleforce创建商机接口的入参
        /// </summary>
        [XmlElement("salesforce_create_leads_request")]
        public SaleForceCreateLeadsParams SalesforceCreateLeadsRequest { get; set; }
    }
}
