using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfleadsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfleadsModifyModel : AopObject
    {
        /// <summary>
        /// 提供给saleforce更新商机接口的入参
        /// </summary>
        [XmlElement("salesforce_update_leads_request")]
        public SaleForceUpdateLeadsParams SalesforceUpdateLeadsRequest { get; set; }
    }
}
