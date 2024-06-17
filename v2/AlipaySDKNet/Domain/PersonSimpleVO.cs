using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PersonSimpleVO Data Structure.
    /// </summary>
    [Serializable]
    public class PersonSimpleVO : AopObject
    {
        /// <summary>
        /// 证件id
        /// </summary>
        [XmlElement("cert_id")]
        public string CertId { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [XmlElement("id_country")]
        public string IdCountry { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 花名
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 人员分类
        /// </summary>
        [XmlElement("person_classfy_type")]
        public string PersonClassfyType { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("person_gender")]
        public string PersonGender { get; set; }

        /// <summary>
        /// 人员id
        /// </summary>
        [XmlElement("person_id")]
        public string PersonId { get; set; }

        /// <summary>
        /// 中文名
        /// </summary>
        [XmlElement("person_name")]
        public string PersonName { get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        [XmlElement("person_name_en")]
        public string PersonNameEn { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
