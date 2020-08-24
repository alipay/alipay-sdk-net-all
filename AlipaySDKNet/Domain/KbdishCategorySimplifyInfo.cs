using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishCategorySimplifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishCategorySimplifyInfo : AopObject
    {
        /// <summary>
        /// 菜谱类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目下菜品列表
        /// </summary>
        [XmlArray("dish_list")]
        [XmlArrayItem("kbdish_cook_detail_simplify_info")]
        public List<KbdishCookDetailSimplifyInfo> DishList { get; set; }

        /// <summary>
        /// 类目是否隐藏，默认不隐藏
        /// </summary>
        [XmlElement("hidden")]
        public bool Hidden { get; set; }

        /// <summary>
        /// 类目标签图片id
        /// </summary>
        [XmlElement("label_image")]
        public string LabelImage { get; set; }

        /// <summary>
        /// 类目排序
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }
    }
}
