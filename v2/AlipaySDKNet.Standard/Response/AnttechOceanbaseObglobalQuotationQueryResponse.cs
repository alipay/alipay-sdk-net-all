using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalQuotationQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalQuotationQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("quotation_desc_list")]
        [XmlArrayItem("string")]
        public List<string> QuotationDescList { get; set; }
    }
}
