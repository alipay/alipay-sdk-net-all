using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampusSchoolQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCampusSchoolQueryModel : AopObject
    {
        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 内标列表
        /// </summary>
        [XmlArray("inst_id_list")]
        [XmlArrayItem("string")]
        public List<string> InstIdList { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 名称模糊匹配
        /// </summary>
        [XmlElement("inst_name_like")]
        public string InstNameLike { get; set; }

        /// <summary>
        /// 外标
        /// </summary>
        [XmlElement("inst_std_code")]
        public string InstStdCode { get; set; }

        /// <summary>
        /// 外标列表
        /// </summary>
        [XmlArray("inst_std_code_list")]
        [XmlArrayItem("string")]
        public List<string> InstStdCodeList { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 学校性质
        /// </summary>
        [XmlElement("school_property")]
        public string SchoolProperty { get; set; }
    }
}
