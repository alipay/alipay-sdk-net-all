using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskSanctionWatchlistCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskSanctionWatchlistCheckModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pbc_scan_params")]
        [XmlArrayItem("p_b_c_scan_param")]
        public List<PBCScanParam> PbcScanParams { get; set; }
    }
}
