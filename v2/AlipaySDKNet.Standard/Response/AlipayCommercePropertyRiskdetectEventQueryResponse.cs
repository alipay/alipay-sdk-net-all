using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyRiskdetectEventQueryResponse.
    /// </summary>
    public class AlipayCommercePropertyRiskdetectEventQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("event_results")]
        [XmlArrayItem("evnet_result_v_o")]
        public List<EvnetResultVO> EventResults { get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
