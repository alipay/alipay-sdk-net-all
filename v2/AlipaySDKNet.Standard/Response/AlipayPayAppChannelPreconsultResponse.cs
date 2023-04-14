using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppChannelPreconsultResponse.
    /// </summary>
    public class AlipayPayAppChannelPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 渠道信息列表
        /// </summary>
        [XmlArray("channel_info_list")]
        [XmlArrayItem("channel_item")]
        public List<ChannelItem> ChannelInfoList { get; set; }

        /// <summary>
        /// 咨询上下文id
        /// </summary>
        [XmlElement("pre_consult_id")]
        public string PreConsultId { get; set; }
    }
}
