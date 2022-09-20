using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanListBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasPutplanListBatchqueryModel : AopObject
    {
        /// <summary>
        /// 渠道类别+不唯一+租户渠道列表查询+数据库
        /// </summary>
        [XmlElement("channel_category")]
        public string ChannelCategory { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 投放计划状态码
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户码，对应门户 SaaS 系统上一个唯一的租户
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }

        /// <summary>
        /// 用户 id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
