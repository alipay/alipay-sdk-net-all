using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateSalesgptChatQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateSalesgptChatQueryModel : AopObject
    {
        /// <summary>
        /// 对话机器人id，由AI导购平台提供
        /// </summary>
        [XmlElement("chat_bot_id")]
        public string ChatBotId { get; set; }

        /// <summary>
        /// 当前页数，默认为1
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 支付宝开放平台中的商户id
        /// </summary>
        [XmlElement("mer_pid")]
        public string MerPid { get; set; }

        /// <summary>
        /// 开放平台用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 每页查询的消息个数，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 请求来源appId
        /// </summary>
        [XmlElement("source_app_id")]
        public string SourceAppId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
