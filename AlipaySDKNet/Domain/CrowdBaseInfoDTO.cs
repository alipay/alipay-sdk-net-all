using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdBaseInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdBaseInfoDTO : AopObject
    {
        /// <summary>
        /// 人群名称
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 文件基本信息
        /// </summary>
        [XmlElement("file_info_dto")]
        public FileInfoDTO FileInfoDto { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 来源方式
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
