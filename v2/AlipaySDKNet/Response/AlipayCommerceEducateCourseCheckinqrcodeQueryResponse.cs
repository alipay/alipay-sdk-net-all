using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCourseCheckinqrcodeQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCourseCheckinqrcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 自动刷新二维码
        /// </summary>
        [XmlElement("automatic_refresh")]
        public bool AutomaticRefresh { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 手动关闭
        /// </summary>
        [XmlElement("manual_close")]
        public bool ManualClose { get; set; }

        /// <summary>
        /// 下一次刷新时间
        /// </summary>
        [XmlElement("next_refresh_time")]
        public string NextRefreshTime { get; set; }

        /// <summary>
        /// 二维码URL
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
