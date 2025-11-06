using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderExpoActivityCreateResponse.
    /// </summary>
    public class AlipayOfflineProviderExpoActivityCreateResponse : AopResponse
    {
        /// <summary>
        /// 活动编码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("solution_v_o_list")]
        [XmlArrayItem("solution_v_o")]
        public List<SolutionVO> SolutionVOList { get; set; }
    }
}
