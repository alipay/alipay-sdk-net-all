using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupPromotechannelBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupPromotechannelBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 群组推广渠道信息列表信息
        /// </summary>
        [XmlElement("group_promote_channel_list")]
        public GroupPromoteChannelVO GroupPromoteChannelList { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页查询结果总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
