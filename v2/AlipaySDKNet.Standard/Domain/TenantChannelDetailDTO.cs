using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TenantChannelDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TenantChannelDetailDTO : AopObject
    {
        /// <summary>
        /// 渠道code + 唯一 + 渠道列表查询 + 数据库
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 渠道描述 + 不唯一 + 渠道列表查询 + 数据库
        /// </summary>
        [XmlElement("channel_desc")]
        public string ChannelDesc { get; set; }

        /// <summary>
        /// 渠道id+唯一+渠道列表查询+数据库
        /// </summary>
        [XmlElement("channel_id")]
        public long ChannelId { get; set; }

        /// <summary>
        /// 渠道名称 + 不唯一 + 渠道列表查询 + 数据库
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 渠道状态+不唯一+（ENABLE-启用、DISABLE-停用）+渠道列表查询+从数据库获取
        /// </summary>
        [XmlElement("channel_status")]
        public string ChannelStatus { get; set; }

        /// <summary>
        /// 租户类型+不唯一+渠道列表查询+EMAIL-邮件、MESSAGE-短信、PUSH-推送、AD-广告）+从数据库获取
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 表单模板id+唯一+渠道列表查询+数据库
        /// </summary>
        [XmlElement("form_template_id")]
        public long FormTemplateId { get; set; }

        /// <summary>
        /// 渠道图片+不唯一+渠道列表查询+数据库
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 备注+不唯一+渠道列表查询+从数据库获取
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 租户渠道授权状态+不唯一+渠道列表查询+（ENABLE-启用、DISABLE-停用）+从数据库获取
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户code+唯一+渠道列表查询+从数据库获取
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
