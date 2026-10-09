using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdMateriallibraryDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdMateriallibraryDeleteModel : AopObject
    {
        /// <summary>
        /// 素材类型，1图片2视频
        /// </summary>
        [XmlElement("material_type")]
        public long MaterialType { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 广告主需要删除的素材id列表值
        /// </summary>
        [XmlArray("user_material_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserMaterialIdList { get; set; }
    }
}
