using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniUserportraitQueryResponse.
    /// </summary>
    public class AlipayOpenMiniUserportraitQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户画像
        /// </summary>
        [XmlArray("portrait_distributions")]
        [XmlArrayItem("portrait_distribution")]
        public List<PortraitDistribution> PortraitDistributions { get; set; }
    }
}
