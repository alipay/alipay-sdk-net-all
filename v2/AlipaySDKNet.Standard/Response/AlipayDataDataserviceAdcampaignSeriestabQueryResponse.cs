using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignSeriestabQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignSeriestabQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("public_list")]
        [XmlArrayItem("ad_public_tab_info")]
        public List<AdPublicTabInfo> PublicList { get; set; }
    }
}
