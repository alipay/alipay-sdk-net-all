using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppxCategoryVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppxCategoryVO : AopObject
    {
        /// <summary>
        /// 类目编号
        /// </summary>
        [XmlElement("cat_id")]
        public string CatId { get; set; }

        /// <summary>
        /// 类目层级
        /// </summary>
        [XmlElement("cat_level")]
        public long CatLevel { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("cat_name")]
        public string CatName { get; set; }

        /// <summary>
        /// 父类目编号
        /// </summary>
        [XmlElement("f_cat_id")]
        public string FCatId { get; set; }
    }
}
