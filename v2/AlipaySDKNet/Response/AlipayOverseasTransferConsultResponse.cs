using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTransferConsultResponse.
    /// </summary>
    public class AlipayOverseasTransferConsultResponse : AopResponse
    {
        /// <summary>
        /// 通道列表
        /// </summary>
        [XmlArray("channel_list")]
        [XmlArrayItem("string")]
        public List<string> ChannelList { get; set; }

        /// <summary>
        /// 默认通道
        /// </summary>
        [XmlElement("default_channel")]
        public string DefaultChannel { get; set; }
    }
}
