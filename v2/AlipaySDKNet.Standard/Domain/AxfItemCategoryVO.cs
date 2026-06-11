using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfItemCategoryVO Data Structure.
    /// </summary>
    [Serializable]
    public class AxfItemCategoryVO : AopObject
    {
        /// <summary>
        /// 类目编码
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目状态
        /// </summary>
        [XmlElement("category_status")]
        public string CategoryStatus { get; set; }

        /// <summary>
        /// 父类目编码
        /// </summary>
        [XmlElement("parent_category_code")]
        public string ParentCategoryCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("required_qualifications")]
        [XmlArrayItem("axf_item_category_qualification_v_o")]
        public List<AxfItemCategoryQualificationVO> RequiredQualifications { get; set; }
    }
}
