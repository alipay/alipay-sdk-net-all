using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionCustomgrayQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionCustomgrayQueryResponse : AopResponse
    {
        /// <summary>
        /// 灰度分组列表
        /// </summary>
        [XmlElement("gray_groups")]
        public MiniAppCustomGrayGroupDto GrayGroups { get; set; }

        /// <summary>
        /// 灰度用户信息列表
        /// </summary>
        [XmlArray("member_infos")]
        [XmlArrayItem("mini_app_custom_gray_member_info_dto")]
        public List<MiniAppCustomGrayMemberInfoDto> MemberInfos { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
