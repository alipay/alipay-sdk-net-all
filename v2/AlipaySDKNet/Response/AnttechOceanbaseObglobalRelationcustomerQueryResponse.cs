using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalRelationcustomerQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalRelationcustomerQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("customer_leads_relation_response")]
        public List<CustomerLeadsRelationResponse> Result { get; set; }
    }
}
