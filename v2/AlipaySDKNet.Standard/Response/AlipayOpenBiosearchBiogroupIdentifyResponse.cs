using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenBiosearchBiogroupIdentifyResponse.
    /// </summary>
    public class AlipayOpenBiosearchBiogroupIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 生物搜索结果，可能没有可能多个
        /// </summary>
        [XmlArray("bio_results")]
        [XmlArrayItem("bio_search_api_result")]
        public List<BioSearchApiResult> BioResults { get; set; }
    }
}
