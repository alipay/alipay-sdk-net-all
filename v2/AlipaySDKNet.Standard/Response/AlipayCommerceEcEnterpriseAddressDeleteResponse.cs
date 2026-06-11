using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseAddressDeleteResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseAddressDeleteResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fail_address_id_list")]
        [XmlArrayItem("string")]
        public List<string> FailAddressIdList { get; set; }
    }
}
