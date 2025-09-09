using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryObArtifactListDTO Data Structure.
    /// </summary>
    [Serializable]
    public class QueryObArtifactListDTO : AopObject
    {
        /// <summary>
        /// 制品版本
        /// </summary>
        [XmlElement("artifact_version")]
        public string ArtifactVersion { get; set; }

        /// <summary>
        /// OB制品产品ID
        /// </summary>
        [XmlElement("boss_id")]
        public long BossId { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 制品名称
        /// </summary>
        [XmlElement("fullname")]
        public string Fullname { get; set; }

        /// <summary>
        /// 制品项目名称
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 制品大小
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// md5值
        /// </summary>
        [XmlElement("unique_data_key")]
        public string UniqueDataKey { get; set; }

        /// <summary>
        /// 制品使用类型
        /// </summary>
        [XmlElement("use_type_str")]
        public string UseTypeStr { get; set; }

        /// <summary>
        /// 制品版本tag字符串
        /// </summary>
        [XmlElement("version_tag_str")]
        public string VersionTagStr { get; set; }
    }
}
