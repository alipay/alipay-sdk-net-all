using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdMateriallibraryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdMateriallibraryQueryModel : AopObject
    {
        /// <summary>
        /// 分页参数
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 素材高度，单位px
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 素材类型，1图片2视频
        /// </summary>
        [XmlElement("material_type")]
        public long MaterialType { get; set; }

        /// <summary>
        /// 素材名称，用于模糊搜索
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 素材库id值
        /// </summary>
        [XmlElement("user_material_lib_id")]
        public string UserMaterialLibId { get; set; }

        /// <summary>
        /// 素材宽
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
