using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHdfServicerightCheckResponse.
    /// </summary>
    public class AlipayCommerceHdfServicerightCheckResponse : AopResponse
    {
        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 是否有权益
        /// </summary>
        [XmlElement("has_right")]
        public bool HasRight { get; set; }

        /// <summary>
        /// 三方UID
        /// </summary>
        [XmlElement("open_partner_user_id")]
        public string OpenPartnerUserId { get; set; }

        /// <summary>
        /// 权益剩余数量
        /// </summary>
        [XmlElement("right_cnt")]
        public string RightCnt { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        [XmlElement("right_end_time")]
        public string RightEndTime { get; set; }

        /// <summary>
        /// 权益开始时间
        /// </summary>
        [XmlElement("right_start_time")]
        public string RightStartTime { get; set; }

        /// <summary>
        /// 权益总数量
        /// </summary>
        [XmlElement("right_total_cnt")]
        public string RightTotalCnt { get; set; }
    }
}
