using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveAdvanceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveAdvanceModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝直播预告id
        /// </summary>
        [XmlElement("alipay_advance_id")]
        public string AlipayAdvanceId { get; set; }

        /// <summary>
        /// 用户生活号标识id
        /// </summary>
        [XmlElement("alipay_public_id")]
        public string AlipayPublicId { get; set; }

        /// <summary>
        /// 预约开播时间 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("live_advance_time")]
        public string LiveAdvanceTime { get; set; }

        /// <summary>
        /// 直播标题
        /// </summary>
        [XmlElement("live_title")]
        public string LiveTitle { get; set; }
    }
}
