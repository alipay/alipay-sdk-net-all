using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubContentRisks Data Structure.
    /// </summary>
    [Serializable]
    public class SubContentRisks : AopObject
    {
        /// <summary>
        /// 能否打标true/false
        /// </summary>
        [XmlElement("can_mark")]
        public bool CanMark { get; set; }

        /// <summary>
        /// 文件素材id，解语花生成的审核素材文件id,查询物料过审规则会用到这个file_id,物料维度打标也会用到这个file_id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 经过素材处理后生成的文件url信息
        /// </summary>
        [XmlElement("generated_url")]
        public string GeneratedUrl { get; set; }

        /// <summary>
        /// 对应外部传入的原始文件url信息
        /// </summary>
        [XmlElement("origin_file")]
        public string OriginFile { get; set; }

        /// <summary>
        /// 原始文件名
        /// </summary>
        [XmlElement("origin_name")]
        public string OriginName { get; set; }

        /// <summary>
        /// 风险规则详情
        /// </summary>
        [XmlArray("risks")]
        [XmlArrayItem("content_risk_detail")]
        public List<ContentRiskDetail> Risks { get; set; }
    }
}
