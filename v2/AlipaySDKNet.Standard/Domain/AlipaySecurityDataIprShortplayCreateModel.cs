using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataIprShortplayCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataIprShortplayCreateModel : AopObject
    {
        /// <summary>
        /// 影视作品中的主要演员及演员所饰演的角色。例如演员张三在剧中饰演的人物角色叫李四，则表示为张三*李四，多个人物角色之间用英文逗号分隔
        /// </summary>
        [XmlElement("actor_role")]
        public string ActorRole { get; set; }

        /// <summary>
        /// 需要保存的影视作品类型，枚举值。根据实际影视作品类型传值。
        /// </summary>
        [XmlElement("art_video_type")]
        public string ArtVideoType { get; set; }

        /// <summary>
        /// 作品授权结束时间，日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("authorize_end_date")]
        public string AuthorizeEndDate { get; set; }

        /// <summary>
        /// 短剧在支付宝平台授权的对应生活号信息
        /// </summary>
        [XmlArray("authorize_life_app_list")]
        [XmlArrayItem("authorize_life_app")]
        public List<AuthorizeLifeApp> AuthorizeLifeAppList { get; set; }

        /// <summary>
        /// 作品授权开始时间，日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("authorize_start_date")]
        public string AuthorizeStartDate { get; set; }

        /// <summary>
        /// 标识外部数据来源渠道，不同渠道对接前请先与接口人确认，每个渠道唯一。错误使用会导致数据保存失败，对接前请务必确认。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 作品主线内容概述
        /// </summary>
        [XmlElement("content_summary")]
        public string ContentSummary { get; set; }

        /// <summary>
        /// 授权材料先通过上传接口上传附件得到文件id
        /// </summary>
        [XmlArray("copyright_material_file_list")]
        [XmlArrayItem("copyright_material_file")]
        public List<CopyrightMaterialFile> CopyrightMaterialFileList { get; set; }

        /// <summary>
        /// 影视作品所属版权方公司名称
        /// </summary>
        [XmlElement("copyright_owner")]
        public string CopyrightOwner { get; set; }

        /// <summary>
        /// 影视作品总导演名称
        /// </summary>
        [XmlElement("director")]
        public string Director { get; set; }

        /// <summary>
        /// 影视作品总集数
        /// </summary>
        [XmlElement("episode_count")]
        public long EpisodeCount { get; set; }

        /// <summary>
        /// 渠道方作品唯一标识
        /// </summary>
        [XmlElement("external_short_play_id")]
        public string ExternalShortPlayId { get; set; }

        /// <summary>
        /// 影视作品在相关平台或者部门备案通过后获取到的备案号
        /// </summary>
        [XmlElement("filing_no")]
        public string FilingNo { get; set; }

        /// <summary>
        /// 每一集短剧截帧数据压缩文件上传得到文件id
        /// </summary>
        [XmlArray("frame_file_list")]
        [XmlArrayItem("short_play_frame_file")]
        public List<ShortPlayFrameFile> FrameFileList { get; set; }

        /// <summary>
        /// 海报图片上传后获取到文件id
        /// </summary>
        [XmlElement("poster_file_id")]
        public string PosterFileId { get; set; }

        /// <summary>
        /// 影视作品发布上线时间，日期格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("release_date")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// 标识影视作品是否发布上线，Y-已上线；N-未上线
        /// </summary>
        [XmlElement("release_flag")]
        public string ReleaseFlag { get; set; }

        /// <summary>
        /// 标识该影视作品是否渠道方所属平台自制
        /// </summary>
        [XmlElement("self_made_flag")]
        public string SelfMadeFlag { get; set; }

        /// <summary>
        /// 影视作品名称
        /// </summary>
        [XmlElement("short_play_name")]
        public string ShortPlayName { get; set; }

        /// <summary>
        /// 一部剧所有集数视频时长总和，单位分钟
        /// </summary>
        [XmlElement("total_duration_minute")]
        public long TotalDurationMinute { get; set; }

        /// <summary>
        /// 标识该剧是否为紧急剧
        /// </summary>
        [XmlElement("urgent_flag")]
        public string UrgentFlag { get; set; }
    }
}
