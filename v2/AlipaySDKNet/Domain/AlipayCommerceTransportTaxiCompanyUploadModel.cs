using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiCompanyUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiCompanyUploadModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("company_list")]
        [XmlArrayItem("company_import_item")]
        public List<CompanyImportItem> CompanyList { get; set; }
    }
}
