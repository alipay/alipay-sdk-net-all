using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseLifecreationShortplayUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseLifecreationShortplayUploadModel : AopObject
    {
        /// <summary>
        /// 生活号+号ID。如果发送类型=自研/三方发送，不要传入；发送类型=mcn发送，请传入public_id【mcn机构绑定达人号ID】
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 内容正文，纯文本，正文长度不超过1000个字
        /// </summary>
        [XmlElement("source_content")]
        public string SourceContent { get; set; }

        /// <summary>
        /// 素材列表，需提交两个素材类型，一个是视频类型，一个是封面类型
        /// </summary>
        [XmlArray("source_media_infos")]
        [XmlArrayItem("short_play_source_media_info")]
        public List<ShortPlaySourceMediaInfo> SourceMediaInfos { get; set; }

        /// <summary>
        /// 标题长度的最大字数为30个字
        /// </summary>
        [XmlElement("source_title")]
        public string SourceTitle { get; set; }
    }
}
