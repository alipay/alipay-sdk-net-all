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

        /// <summary>
        /// 该参数为Map结构，用于在二方前置咨询返回一些基于特殊业务场景可选返回的参数
        /// </summary>
        [XmlElement("ext_info")]
        public BizExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 前置咨询id
        /// </summary>
        [XmlElement("pre_consult_id")]
        public string PreConsultId { get; set; }

        /// <summary>
        /// 真实账号
        /// </summary>
        [XmlElement("real_alipay_account_id")]
        public string RealAlipayAccountId { get; set; }

        /// <summary>
        /// 真实账号
        /// </summary>
        [XmlElement("real_alipay_open_id")]
        public string RealAlipayOpenId { get; set; }

        /// <summary>
        /// 虚拟账号
        /// </summary>
        [XmlElement("virtual_alipay_open_id")]
        public string VirtualAlipayOpenId { get; set; }

        /// <summary>
        /// 虚拟账号
        /// </summary>
        [XmlElement("virtual_alipay_user_id")]
        public string VirtualAlipayUserId { get; set; }
    }
}
