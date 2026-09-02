using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignSeriestabcompilationQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignSeriestabcompilationQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("compilation_list")]
        [XmlArrayItem("ad_series_tab_compilation_resp")]
        public List<AdSeriesTabCompilationResp> CompilationList { get; set; }
    }
}
