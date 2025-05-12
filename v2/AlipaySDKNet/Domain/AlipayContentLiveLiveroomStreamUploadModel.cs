using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveLiveroomStreamUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveLiveroomStreamUploadModel : AopObject
    {
        /// <summary>
        /// 脱敏后的支付宝直播间ID
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 主播生活号ID
        /// </summary>
        [XmlElement("alipay_public_id")]
        public string AlipayPublicId { get; set; }

        /// <summary>
        /// 直播流地址
        /// </summary>
        [XmlElement("live_stream_url")]
        public string LiveStreamUrl { get; set; }
    }
}
