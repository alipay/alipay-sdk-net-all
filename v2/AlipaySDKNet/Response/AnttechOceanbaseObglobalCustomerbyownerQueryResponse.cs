using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerbyownerQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalCustomerbyownerQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("customer_with_platform_users_response")]
        public List<CustomerWithPlatformUsersResponse> Result { get; set; }
    }
}
