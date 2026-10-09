using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LiveContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LiveContentInfo : AopObject
    {
        /// <summary>
        /// 素材的业务类型，可以区分针对不同素材匹配不同的业务规则。
        /// </summary>
        [XmlElement("biz_content_type")]
        public string BizContentType { get; set; }

        /// <summary>
        /// 物料类型 (TEXT:文本/PICTURE:图片/VOICE:语音/VIDEO:视频)
        /// </summary>
        [XmlElement("content_file_type")]
        public string ContentFileType { get; set; }

        /// <summary>
        /// 物料的唯一代码
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 物料风险信息列表
        /// </summary>
        [XmlArray("content_risk_info_list")]
        [XmlArrayItem("live_content_risk_info")]
        public List<LiveContentRiskInfo> ContentRiskInfoList { get; set; }

        /// <summary>
        /// 视频转换的文本的url地址
        /// </summary>
        [XmlElement("content_url")]
        public string ContentUrl { get; set; }

        /// <summary>
        /// 打点标签名称
        /// </summary>
        [XmlElement("mark_lable_name")]
        public string MarkLableName { get; set; }
    }
}
