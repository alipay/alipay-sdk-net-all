using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcPointRefreshResource Data Structure.
    /// </summary>
    [Serializable]
    public class NfcPointRefreshResource : AopObject
    {
        /// <summary>
        /// 素材文件地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 素材标识
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 素材在海报计划中配置的展示位置，取值随素材配置变化
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }

        /// <summary>
        /// 素材文件格式，取值由海报计划关联的素材文件决定，不限定固定枚举
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
