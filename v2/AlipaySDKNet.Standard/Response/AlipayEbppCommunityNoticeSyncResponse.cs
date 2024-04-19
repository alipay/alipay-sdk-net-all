using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityNoticeSyncResponse.
    /// </summary>
    public class AlipayEbppCommunityNoticeSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝通知id
        /// </summary>
        [XmlElement("alipay_notice_id")]
        public string AlipayNoticeId { get; set; }
    }
}
