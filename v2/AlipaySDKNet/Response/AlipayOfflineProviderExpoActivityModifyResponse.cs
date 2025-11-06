using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderExpoActivityModifyResponse.
    /// </summary>
    public class AlipayOfflineProviderExpoActivityModifyResponse : AopResponse
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("solution_update_v_o_list")]
        [XmlArrayItem("solution_open_api_v_o")]
        public List<SolutionOpenApiVO> SolutionUpdateVOList { get; set; }
    }
}
