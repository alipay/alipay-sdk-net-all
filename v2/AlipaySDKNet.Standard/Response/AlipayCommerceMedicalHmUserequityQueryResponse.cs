using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmUserequityQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmUserequityQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("equity_info_list")]
        [XmlArrayItem("hm_equity_info")]
        public List<HmEquityInfo> EquityInfoList { get; set; }
    }
}
