using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneOrderPreconsultResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCreditphoneOrderPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 渠道列表
        /// </summary>
        [XmlArray("channel_list")]
        [XmlArrayItem("consult_channel_response")]
        public List<ConsultChannelResponse> ChannelList { get; set; }

        /// <summary>
        /// 咨询是否通过
        /// </summary>
        [XmlElement("pass")]
        public bool Pass { get; set; }

        /// <summary>
        /// 拒绝列表
        /// </summary>
        [XmlArray("refuse_list")]
        [XmlArrayItem("consult_refuse_response")]
        public List<ConsultRefuseResponse> RefuseList { get; set; }
    }
}
