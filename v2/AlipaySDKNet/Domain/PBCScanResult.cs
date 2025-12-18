using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PBCScanResult Data Structure.
    /// </summary>
    [Serializable]
    public class PBCScanResult : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("hit_details")]
        [XmlArrayItem("p_b_c_hit_detail")]
        public List<PBCHitDetail> HitDetails { get; set; }
    }
}
