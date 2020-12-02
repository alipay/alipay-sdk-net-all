using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppChannelConsultResponse.
    /// </summary>
    public class AlipayPayAppChannelConsultResponse : AopResponse
    {
        /// <summary>
        /// 渠道信息列表
        /// </summary>
        [XmlArray("channel_info_list")]
        [XmlArrayItem("channel_info")]
        public List<ChannelInfo> ChannelInfoList { get; set; }
    }
}
