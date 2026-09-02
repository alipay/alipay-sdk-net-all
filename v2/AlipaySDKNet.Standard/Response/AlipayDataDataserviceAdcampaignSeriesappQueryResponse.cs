using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignSeriesappQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignSeriesappQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("app_list")]
        [XmlArrayItem("ad_app_info")]
        public List<AdAppInfo> AppList { get; set; }
    }
}
