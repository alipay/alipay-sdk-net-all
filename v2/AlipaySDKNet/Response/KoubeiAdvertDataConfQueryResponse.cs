using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertDataConfQueryResponse.
    /// </summary>
    public class KoubeiAdvertDataConfQueryResponse : AopResponse
    {
        /// <summary>
        /// 渠道类型配置
        /// </summary>
        [XmlArray("channel_types")]
        [XmlArrayItem("kbadvert_channel_type_response")]
        public List<KbadvertChannelTypeResponse> ChannelTypes { get; set; }

        /// <summary>
        /// 分佣配置金额
        /// </summary>
        [XmlArray("commission_limits")]
        [XmlArrayItem("kbadvert_commission_limit")]
        public List<KbadvertCommissionLimit> CommissionLimits { get; set; }
    }
}
