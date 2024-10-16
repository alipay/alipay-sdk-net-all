using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneCategoryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SceneCategoryDTO : AopObject
    {
        /// <summary>
        /// 类目信息列表
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("category_info_d_t_o")]
        public List<CategoryInfoDTO> CategoryList { get; set; }

        /// <summary>
        /// 服务商已签约场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }
    }
}
