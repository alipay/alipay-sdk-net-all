using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelCreateResponse.
    /// </summary>
    public class KoubeiAdvertCommissionChannelCreateResponse : AopResponse
    {
        /// <summary>
        /// 新增渠道接口，需要记录渠道ID
        /// </summary>
        [XmlArray("channel_response")]
        [XmlArrayItem("kb_advert_channel_response")]
        public List<KbAdvertChannelResponse> ChannelResponse { get; set; }
    }
}
