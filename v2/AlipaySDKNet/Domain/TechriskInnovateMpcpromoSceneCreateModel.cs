using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoSceneCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoSceneCreateModel : AopObject
    {
        /// <summary>
        /// 商品数据的列表；创建场景时所选中的商品数据需为
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("string")]
        public List<string> DataList { get; set; }

        /// <summary>
        /// 推荐对象类型，目前仅支持商品，默认为GOODS。
        /// </summary>
        [XmlElement("recommend_type")]
        public string RecommendType { get; set; }

        /// <summary>
        /// 场景描述
        /// </summary>
        [XmlElement("scene_description")]
        public string SceneDescription { get; set; }

        /// <summary>
        /// 场景项目名称
        /// </summary>
        [XmlElement("scene_project_name")]
        public string SceneProjectName { get; set; }
    }
}
