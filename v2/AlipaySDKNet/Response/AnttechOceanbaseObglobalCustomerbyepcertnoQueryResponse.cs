using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerbyepcertnoQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalCustomerbyepcertnoQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("ep_cert_no_customer_info_d_t_o")]
        public List<EpCertNoCustomerInfoDTO> Result { get; set; }
    }
}
