using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateRosterInfoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateRosterInfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 花名册列表
        /// </summary>
        [XmlArray("roster_list")]
        [XmlArrayItem("edu_roster_info")]
        public List<EduRosterInfo> RosterList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
