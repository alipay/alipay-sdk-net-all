using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserInviteRtaConsultResponse.
    /// </summary>
    public class AlipayUserInviteRtaConsultResponse : AopResponse
    {
        /// <summary>
        /// 人群标签
        /// </summary>
        [XmlElement("principal_label")]
        public string PrincipalLabel { get; set; }

        /// <summary>
        /// 是否需要的流量
        /// </summary>
        [XmlElement("required_flow")]
        public bool RequiredFlow { get; set; }

        /// <summary>
        /// rta咨询结果列表
        /// </summary>
        [XmlArray("rta_info_list")]
        [XmlArrayItem("rta_info")]
        public List<RtaInfo> RtaInfoList { get; set; }
    }
}
