using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityDeliverychannelQueryResponse.
    /// </summary>
    public class AlipayMarketingActivityDeliverychannelQueryResponse : AopResponse
    {
        /// <summary>
        /// 可投放的渠道信息列表。 用于表达当前可以投放的渠道列表信息
        /// </summary>
        [XmlArray("delivery_channel_info_list")]
        [XmlArrayItem("delivery_channel_info")]
        public List<DeliveryChannelInfo> DeliveryChannelInfoList { get; set; }

        /// <summary>
        /// 查询的页码。 特别说明： 页码从1开始。
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页查询个数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 可返回的渠道总数
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
