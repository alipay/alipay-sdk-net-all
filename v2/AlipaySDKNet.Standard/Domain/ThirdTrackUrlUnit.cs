using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ThirdTrackUrlUnit Data Structure.
    /// </summary>
    [Serializable]
    public class ThirdTrackUrlUnit : AopObject
    {
        /// <summary>
        /// 业务类型。COMMON：通用；MIAO_ZHEN：秒针；ReachMax：ReachMax
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 上报方式： S2S：S2S C2S：C2S
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// 监测类型。IMPRESSION：曝光；CLICK：点击；DEEPLINK_CLICK：唤端点击同步；TARGETURL_CLICK：落地页点击同步
        /// </summary>
        [XmlElement("track_type")]
        public string TrackType { get; set; }

        /// <summary>
        /// 监测链接： 当track_type选择DEEPLINK_CLICK、TARGETURL_CLICK时，不需要额外传入
        /// </summary>
        [XmlElement("track_url")]
        public string TrackUrl { get; set; }
    }
}
