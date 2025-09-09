using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappLayerchannelQueryResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappLayerchannelQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回该小程序下所拥有对应渠道列表
        /// </summary>
        [XmlArray("channel_code_list")]
        [XmlArrayItem("channel_code_info")]
        public List<ChannelCodeInfo> ChannelCodeList { get; set; }
    }
}
