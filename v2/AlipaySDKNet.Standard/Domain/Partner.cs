using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Partner Data Structure.
    /// </summary>
    [Serializable]
    public class Partner : AopObject
    {
        /// <summary>
        /// 是否用印主题
        /// </summary>
        [XmlElement("need_seal_entity")]
        public string NeedSealEntity { get; set; }

        /// <summary>
        /// 公司OU
        /// </summary>
        [XmlElement("ou")]
        public string Ou { get; set; }

        /// <summary>
        /// 对方公司详细地址
        /// </summary>
        [XmlElement("part_b_addr")]
        public string PartBAddr { get; set; }

        /// <summary>
        /// 对方公司所属城市
        /// </summary>
        [XmlElement("part_b_city")]
        public string PartBCity { get; set; }

        /// <summary>
        /// 对方公司所属国家
        /// </summary>
        [XmlElement("part_b_country")]
        public string PartBCountry { get; set; }

        /// <summary>
        /// 对方公司所属省份
        /// </summary>
        [XmlElement("part_b_province")]
        public string PartBProvince { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("partner_name")]
        public string PartnerName { get; set; }
    }
}
