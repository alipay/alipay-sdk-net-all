using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcReconnectioninfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfrtcReconnectioninfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 频道ID
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 是否是视频重连进入 0:否 1:是
        /// </summary>
        [XmlElement("if_video_conference_reconnect")]
        public long IfVideoConferenceReconnect { get; set; }

        /// <summary>
        /// 来源ID
        /// </summary>
        [XmlElement("source_id")]
        public long SourceId { get; set; }

        /// <summary>
        /// 弹窗提示文案
        /// </summary>
        [XmlElement("tips")]
        public string Tips { get; set; }

        /// <summary>
        /// 视频会议ID
        /// </summary>
        [XmlElement("video_conference_id")]
        public long VideoConferenceId { get; set; }
    }
}
