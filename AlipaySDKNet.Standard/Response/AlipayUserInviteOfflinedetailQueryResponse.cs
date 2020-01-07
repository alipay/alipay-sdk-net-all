using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserInviteOfflinedetailQueryResponse.
    /// </summary>
    public class AlipayUserInviteOfflinedetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 线下拉新结算明细数据列表
        /// </summary>
        [XmlArray("offline_detail_info_list")]
        [XmlArrayItem("offline_invite_newer_detail_info")]
        public List<OfflineInviteNewerDetailInfo> OfflineDetailInfoList { get; set; }

        /// <summary>
        /// 总记录数
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
