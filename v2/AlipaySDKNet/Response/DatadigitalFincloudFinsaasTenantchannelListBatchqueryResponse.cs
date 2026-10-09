using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasTenantchannelListBatchqueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasTenantchannelListBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 租户渠道列表+不唯一+租户渠道列表查询+数据库
        /// </summary>
        [XmlArray("tenant_channel_list")]
        [XmlArrayItem("tenant_channel_detail_d_t_o")]
        public List<TenantChannelDetailDTO> TenantChannelList { get; set; }
    }
}
