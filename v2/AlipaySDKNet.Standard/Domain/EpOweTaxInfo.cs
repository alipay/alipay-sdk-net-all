using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpOweTaxInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpOweTaxInfo : AopObject
    {
        /// <summary>
        /// 识别号
        /// </summary>
        [XmlElement("identify_number")]
        public string IdentifyNumber { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 法定代表人姓名
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 经营地址
        /// </summary>
        [XmlElement("manage_address")]
        public string ManageAddress { get; set; }

        /// <summary>
        /// 金额，单位万元
        /// </summary>
        [XmlElement("money")]
        public string Money { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 公告
        /// </summary>
        [XmlElement("notice_type")]
        public string NoticeType { get; set; }

        /// <summary>
        /// 税务机关
        /// </summary>
        [XmlElement("taxes_organ")]
        public string TaxesOrgan { get; set; }

        /// <summary>
        /// 税种
        /// </summary>
        [XmlElement("taxes_type")]
        public string TaxesType { get; set; }
    }
}
