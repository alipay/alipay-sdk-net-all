using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcSceneQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MpcSceneQueryInfo : AopObject
    {
        /// <summary>
        /// 商品id列表
        /// </summary>
        [XmlArray("goods_id")]
        [XmlArrayItem("string")]
        public List<string> GoodsId { get; set; }

        /// <summary>
        /// 最后更新人
        /// </summary>
        [XmlElement("last_operator")]
        public string LastOperator { get; set; }

        /// <summary>
        /// 坑位id
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }

        /// <summary>
        /// 推荐对象类型
        /// </summary>
        [XmlElement("recomment_type")]
        public string RecommentType { get; set; }

        /// <summary>
        /// 场景描述
        /// </summary>
        [XmlElement("scene_description")]
        public string SceneDescription { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 场景项目名称
        /// </summary>
        [XmlElement("scene_project_name")]
        public string SceneProjectName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
