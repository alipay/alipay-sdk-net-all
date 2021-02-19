using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwArticleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwArticleModifyModel : AopObject
    {
        /// <summary>
        /// 所属类目ID，如果search_all_category为true则不用填
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 扩展标题
        /// </summary>
        [XmlArray("extend_titles")]
        [XmlArrayItem("string")]
        public List<string> ExtendTitles { get; set; }

        /// <summary>
        /// 文章ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlArray("keywords")]
        [XmlArrayItem("string")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 场景ID。1（内部知识库）；2（机器人）;3（帮助中心）；4（无线帮助中心）
        /// </summary>
        [XmlArray("scene_codes")]
        [XmlArrayItem("string")]
        public List<string> SceneCodes { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
