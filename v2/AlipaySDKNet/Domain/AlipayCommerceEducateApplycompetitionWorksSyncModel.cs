using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateApplycompetitionWorksSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateApplycompetitionWorksSyncModel : AopObject
    {
        /// <summary>
        /// 参赛状态，参赛状态0:已报名，1:已支付，2:已参赛
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 扩展信息JSON格式
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 文件类型1：图片，2：视频
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 参赛者作品url
        /// </summary>
        [XmlElement("files_url")]
        public string FilesUrl { get; set; }

        /// <summary>
        /// 参赛者id,由支付宝生成
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 外部赛事id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
