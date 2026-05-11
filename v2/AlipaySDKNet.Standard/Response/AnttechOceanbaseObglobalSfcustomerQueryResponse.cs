using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcustomerQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfcustomerQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("customer_query_response_d_t_o")]
        public List<CustomerQueryResponseDTO> Result { get; set; }
    }
}
