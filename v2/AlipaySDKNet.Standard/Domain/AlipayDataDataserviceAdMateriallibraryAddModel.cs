using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdMateriallibraryAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdMateriallibraryAddModel : AopObject
    {
        /// <summary>
        /// 文件id值
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 用于保存素材文件的名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 1表示图片，2表示视频
        /// </summary>
        [XmlElement("material_type")]
        public long MaterialType { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
