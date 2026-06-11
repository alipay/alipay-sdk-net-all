using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentAgentChatModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentAgentChatModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("biz_entity_ids")]
        [XmlArrayItem("biz_entity")]
        public List<BizEntity> BizEntityIds { get; set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商户查询条件
        /// </summary>
        [XmlElement("merchant_query_condition")]
        public string MerchantQueryCondition { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部会话ID，商户侧唯一标识一次会话（商户侧生成）
        /// </summary>
        [XmlElement("out_session_id")]
        public string OutSessionId { get; set; }

        /// <summary>
        /// 用户问询内容
        /// </summary>
        [XmlElement("query_content")]
        public string QueryContent { get; set; }

        /// <summary>
        /// 用户id，支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
