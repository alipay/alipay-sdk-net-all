using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentSyncDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskContentSyncDetectModel : AopObject
    {
        /// <summary>
        /// 来源渠道，按照实际申请开通的产品权限相应传值： Riskgo内容风险识别：tinyapp-eco-open 小程序云内容风险识别：miniappcloud（文本），miniappcloud-oss（图片OSS） 数科内容风险识别：digital-tech（数科生产），digital-tech-poc（数科POC）
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 送检内容类型枚举值： 图片:PICTURE，文本:TEXT
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 用户发表内容，建议对内容中的格式符号、表情符、HTML标签、UBB标签等做过滤，只传递纯文本，以减少误判（当前仅支持单图调用，多图调用待后续升级使用），当前接口仅支持单一内容传入。
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("string")]
        public List<string> DataList { get; set; }

        /// <summary>
        /// OPENID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 不同客户可能存在差异，按实际检测需求传值即可，当前支持的检测服务码：TJ_POLITICS_MC：敏感；TJ_PORN_MC：色情；TJ_ILLEGAL_MC：违禁；TJ_TERRORISM_MC：暴恐，TJ_ABUSES_MC：谩骂，其他需求请与蚂蚁内容安全客户经理沟通获取
        /// </summary>
        [XmlElement("products")]
        public string Products { get; set; }

        /// <summary>
        /// 唯一请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenants")]
        public string Tenants { get; set; }

        /// <summary>
        /// 内容发布账号ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
