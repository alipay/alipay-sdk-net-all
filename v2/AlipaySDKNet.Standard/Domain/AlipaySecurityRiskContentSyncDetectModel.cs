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
        /// 来源渠道，请与蚂蚁业务同学沟通获取
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 送检内容类型
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 用户发表内容，建议对内容中的格式符号、表情符、HTML标签、UBB标签等做过滤，只传递纯文本，以减少误判
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("string")]
        public List<string> DataList { get; set; }

        /// <summary>
        /// 服务码列表
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
