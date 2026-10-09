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
        /// 一个或多个咨询策略标签，若返回多个标签，中间用“-”分隔
        /// </summary>
        [XmlElement("principal_label")]
        public string PrincipalLabel { get; set; }

        /// <summary>
        /// 是否需要的流量，结果可为true和false
        /// </summary>
        [XmlElement("required_flow")]
        public bool RequiredFlow { get; set; }

        /// <summary>
        /// rta咨询结果列表。最终结果形如：[{"accountId":"11111"},{"accountId":"22222"}]
        /// </summary>
        [XmlArray("rta_info_list")]
        [XmlArrayItem("rta_info")]
        public List<RtaInfo> RtaInfoList { get; set; }
    }
}
