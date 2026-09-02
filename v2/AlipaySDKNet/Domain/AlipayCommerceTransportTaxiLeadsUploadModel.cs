using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiLeadsUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiLeadsUploadModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("leads_list")]
        [XmlArrayItem("leads_import_item")]
        public List<LeadsImportItem> LeadsList { get; set; }
    }
}
