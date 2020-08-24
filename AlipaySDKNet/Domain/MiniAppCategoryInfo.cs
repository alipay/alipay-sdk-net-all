using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppCategoryInfo : AopObject
    {
        /// <summary>
        /// 一级类目id
        /// </summary>
        [XmlElement("first_category_id")]
        public string FirstCategoryId { get; set; }

        /// <summary>
        /// 一级类目名称
        /// </summary>
        [XmlElement("first_category_name")]
        public string FirstCategoryName { get; set; }

        /// <summary>
        /// 二级类目id
        /// </summary>
        [XmlElement("second_category_id")]
        public string SecondCategoryId { get; set; }

        /// <summary>
        /// 二级类目名称
        /// </summary>
        [XmlElement("second_category_name")]
        public string SecondCategoryName { get; set; }

        /// <summary>
        /// 三级类目id，可空
        /// </summary>
        [XmlElement("third_category_id")]
        public string ThirdCategoryId { get; set; }

        /// <summary>
        /// 三级类目名称，可空
        /// </summary>
        [XmlElement("third_category_name")]
        public string ThirdCategoryName { get; set; }
    }
}
