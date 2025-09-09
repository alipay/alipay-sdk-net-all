using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveAdvanceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveAdvanceCreateModel : AopObject
    {
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
        /// 对直播主题的简短描述
        /// </summary>
        [XmlElement("live_title")]
        public string LiveTitle { get; set; }

        /// <summary>
        /// 外部的预告id，和支付宝直播域的预告id有关联
        /// </summary>
        [XmlElement("out_advance_id")]
        public string OutAdvanceId { get; set; }
    }
}
