using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcsmartLivecontentQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcsmartLivecontentQueryResponse : AopResponse
    {
        /// <summary>
        /// 直播信息列表
        /// </summary>
        [XmlArray("live_info_list")]
        [XmlArrayItem("live_info")]
        public List<LiveInfo> LiveInfoList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
