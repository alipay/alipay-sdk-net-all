using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterBenefitDeleteResponse.
    /// </summary>
    public class AlipayOfflineProviderNpassporterBenefitDeleteResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OpenIdList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("uid_list")]
        [XmlArrayItem("string")]
        public List<string> UidList { get; set; }
    }
}
