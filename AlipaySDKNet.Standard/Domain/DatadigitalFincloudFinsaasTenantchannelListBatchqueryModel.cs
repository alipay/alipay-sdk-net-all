using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasTenantchannelListBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasTenantchannelListBatchqueryModel : AopObject
    {
        /// <summary>
        /// 渠道类别+不唯一+租户渠道列表查询+数据库
        /// </summary>
        [XmlElement("channel_category")]
        public string ChannelCategory { get; set; }

        /// <summary>
        /// 租户渠道状态+不唯一+租户渠道列表查询+数据库
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户code
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
