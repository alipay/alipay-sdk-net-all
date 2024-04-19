using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasChannelQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasChannelQueryResponse : AopResponse
    {
        /// <summary>
        /// 渠道code+唯一+获取渠道详情+从数据库获取
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 渠道简介+不唯一+获取渠道详情+从数据库获取
        /// </summary>
        [XmlElement("channel_desc")]
        public string ChannelDesc { get; set; }

        /// <summary>
        /// 渠道名称+不唯一+获取渠道详情+从数据库获取
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 渠道规则+不唯一+获取渠道详情+从数据库获取
        /// </summary>
        [XmlElement("channel_rule")]
        public ChannelRuleDTO ChannelRule { get; set; }

        /// <summary>
        /// 渠道使用范围+不唯一+获取渠道详情+（COMMON-通用、ASSIGN-指定租户）从数据库获取
        /// </summary>
        [XmlElement("channel_scope")]
        public string ChannelScope { get; set; }

        /// <summary>
        /// 渠道状态+唯一+获取渠道详情+（ENABLE-启用、DISABLE-停用）+从数据库获取
        /// </summary>
        [XmlElement("channel_status")]
        public string ChannelStatus { get; set; }

        /// <summary>
        /// 渠道模板+不唯一+获取渠道详情+从数据库获取
        /// </summary>
        [XmlElement("channel_template")]
        public string ChannelTemplate { get; set; }

        /// <summary>
        /// 渠道租户code+不唯一+获取渠道详情+从数据库获取
        /// </summary>
        [XmlElement("channel_tenant_code")]
        public string ChannelTenantCode { get; set; }

        /// <summary>
        /// 渠道类型+不唯一+获取渠道详情+（EMAIL-邮件、MESSAGE-短信、PUSH-推送、AD-广告）+从数据库获取
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 创建时间+不唯一+获取渠道详情+从数据库获取
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间+不唯一+获取渠道详情+从数据库获取
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 渠道id+唯一+获取获取详情+数据库
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 渠道图片+不唯一+获取渠道详情+从数据库获取
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }
    }
}
