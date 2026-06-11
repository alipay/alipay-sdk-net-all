using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalQuotationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalQuotationQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("quotation_no_list")]
        [XmlArrayItem("string")]
        public List<string> QuotationNoList { get; set; }
    }
}
