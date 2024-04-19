using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateAuthenticateCampuscardCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateAuthenticateCampuscardCreateModel : AopObject
    {
        /// <summary>
        /// 校区
        /// </summary>
        [XmlElement("campus")]
        public string Campus { get; set; }

        /// <summary>
        /// 自然人在学校唯一编号
        /// </summary>
        [XmlElement("campus_no")]
        public string CampusNo { get; set; }

        /// <summary>
        /// 1学生卡，2教工卡，3临时卡，4其他 不传默认是学生卡
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 毕业时间
        /// </summary>
        [XmlElement("expire_at")]
        public string ExpireAt { get; set; }

        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 学生/教职工在学校唯一短号，由isv分配
        /// </summary>
        [XmlElement("isv_short_code")]
        public string IsvShortCode { get; set; }

        /// <summary>
        /// 组织信息,多个分组以;隔开：AA/BB/CC;A/B/C
        /// </summary>
        [XmlElement("organization")]
        public string Organization { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校国标码
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
