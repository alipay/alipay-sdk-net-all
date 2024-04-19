using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniResourceRecordNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniResourceRecordNotifyModel : AopObject
    {
        /// <summary>
        /// 媒体唤起时传入的支付宝id
        /// </summary>
        [XmlElement("author_id")]
        public string AuthorId { get; set; }

        /// <summary>
        /// 支付宝appid，代表一个小程序的唯一标识
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 媒体唤起时提供的额外参数值列表，这里可能有多个值，打平以后拼入。即url_decode(authcbparams)
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 回调的siteid 淘宝账号唯一
        /// </summary>
        [XmlElement("site_id")]
        public string SiteId { get; set; }

        /// <summary>
        /// 媒体来源，标识调用方
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 淘宝id
        /// </summary>
        [XmlElement("taobao_id")]
        public string TaobaoId { get; set; }

        /// <summary>
        /// 淘宝昵称
        /// </summary>
        [XmlElement("taobao_nick")]
        public string TaobaoNick { get; set; }
    }
}
