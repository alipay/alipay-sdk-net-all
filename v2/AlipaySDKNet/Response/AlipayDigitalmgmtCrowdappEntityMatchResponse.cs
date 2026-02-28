using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtCrowdappEntityMatchResponse.
    /// </summary>
    public class AlipayDigitalmgmtCrowdappEntityMatchResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("hit_crowd_app_ids")]
        [XmlArrayItem("string")]
        public List<string> HitCrowdAppIds { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("not_hit_crowd_app_ids")]
        [XmlArrayItem("string")]
        public List<string> NotHitCrowdAppIds { get; set; }
    }
}
