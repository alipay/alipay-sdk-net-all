using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampusInstitutionsAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCampusInstitutionsAddModel : AopObject
    {
        /// <summary>
        /// 事业单位法人证书或办学许可证的图片。入驻学校时，如果流入人工审核，会根据此图片进行辅助验证。
        /// </summary>
        [XmlElement("card_pict_url")]
        public string CardPictUrl { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 入驻的学校名称，必须是完整的学校全称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 学校外标，使用统一社会信用编码
        /// </summary>
        [XmlElement("inst_std_code")]
        public string InstStdCode { get; set; }

        /// <summary>
        /// 办学阶段。 枚举值如下： KINDERGARTEN（幼儿园） PRIMARY_SCHOOL（小学）  MIDDLE_SCHOOL（初中）  HIGH_SCHOOL（高中） SECONDARY_VOCATIONAL_SCHOOL（中职中专）  注意：如果学校兼有多种属性，可以连写用英文逗号拆分，如：MIDDLE_SCHOOL,HIGH_SCHOOL 代表兼有初中部和高中部；
        /// </summary>
        [XmlElement("learning_stage")]
        public string LearningStage { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 学校性质.枚举值如下：  1：公立  2：民办
        /// </summary>
        [XmlElement("school_property")]
        public string SchoolProperty { get; set; }
    }
}
