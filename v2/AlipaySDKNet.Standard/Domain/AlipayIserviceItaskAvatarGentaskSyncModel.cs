using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceItaskAvatarGentaskSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceItaskAvatarGentaskSyncModel : AopObject
    {
        /// <summary>
        /// 位置信息
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 多分镜配置
        /// </summary>
        [XmlArray("multi_page_config")]
        [XmlArrayItem("avatar_multi_page_config")]
        public List<AvatarMultiPageConfig> MultiPageConfig { get; set; }

        /// <summary>
        /// 播报内容，不超过1000个字
        /// </summary>
        [XmlElement("ori_text")]
        public string OriText { get; set; }

        /// <summary>
        /// 播报列表，最终会替换到模版上
        /// </summary>
        [XmlArray("ori_text_list")]
        [XmlArrayItem("string")]
        public List<string> OriTextList { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [XmlElement("project_id")]
        public long ProjectId { get; set; }

        /// <summary>
        /// 分辨率，720/1080两种
        /// </summary>
        [XmlElement("resolution")]
        public string Resolution { get; set; }

        /// <summary>
        /// 发生3.0级地震
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 如果模版只有一个页面，分镜有多个页面，如果传入true，会自动把模版应用于所有分镜
        /// </summary>
        [XmlElement("template_apply_all_page")]
        public bool TemplateApplyAllPage { get; set; }

        /// <summary>
        /// 导出视频的模版id
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 租户code
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }

        /// <summary>
        /// 填入视频名称，不要超过15个字
        /// </summary>
        [XmlElement("video_name")]
        public string VideoName { get; set; }

        /// <summary>
        /// 产出视频类型，默认mp4
        /// </summary>
        [XmlElement("video_type")]
        public string VideoType { get; set; }
    }
}
