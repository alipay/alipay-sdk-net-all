using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserInviteOnlinesummaryQueryResponse.
    /// </summary>
    public class AlipayUserInviteOnlinesummaryQueryResponse : AopResponse
    {
        /// <summary>
        /// 线上拉新结算汇总数据列表
        /// </summary>
        [XmlArray("online_summary_info_list")]
        [XmlArrayItem("online_invite_newer_summary_info")]
        public List<OnlineInviteNewerSummaryInfo> OnlineSummaryInfoList { get; set; }
    }
}
