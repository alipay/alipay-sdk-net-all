using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserInviteOnlinedetailQueryResponse.
    /// </summary>
    public class AlipayUserInviteOnlinedetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 线上拉新结算明细数据列表
        /// </summary>
        [XmlArray("online_detail_info_list")]
        [XmlArrayItem("online_invite_newer_detail_info")]
        public List<OnlineInviteNewerDetailInfo> OnlineDetailInfoList { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
