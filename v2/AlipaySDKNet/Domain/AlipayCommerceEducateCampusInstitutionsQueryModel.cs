using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampusInstitutionsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCampusInstitutionsQueryModel : AopObject
    {
        /// <summary>
        /// 城市编码，编码标准为中华人民共和国行政区划代码，参见 2020年12月中华人民共和国县以上行政区划代码。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 学校内标：支付宝内部学校唯一编号。使用内标查询时，默认使用内标进行精确匹配。
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 学校外标：统一社会信用编码或教育部提供的学校标识码。使用学校外标查询时，默认使用外标进行精确匹配。
        /// </summary>
        [XmlElement("inst_std_code")]
        public string InstStdCode { get; set; }

        /// <summary>
        /// 是否使用学校名称模糊匹配进行查询，默认精确匹配。 枚举值如下： 1：精确匹配； 0：模糊匹配
        /// </summary>
        [XmlElement("like_property")]
        public string LikeProperty { get; set; }

        /// <summary>
        /// 省份编码，编码标准为中华人民共和国行政区划代码，参见 2020年12月中华人民共和国县以上行政区划代码。
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
