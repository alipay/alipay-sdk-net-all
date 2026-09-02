using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignSeriesappcompilationQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignSeriesappcompilationQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("compilation_list")]
        [XmlArrayItem("ad_series_app_compilation_resp")]
        public List<AdSeriesAppCompilationResp> CompilationList { get; set; }
    }
}
