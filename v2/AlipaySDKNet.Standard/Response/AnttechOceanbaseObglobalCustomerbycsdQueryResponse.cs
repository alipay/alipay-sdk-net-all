using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerbycsdQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalCustomerbycsdQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("customer_with_platform_users_resp")]
        public List<CustomerWithPlatformUsersResp> Result { get; set; }
    }
}
