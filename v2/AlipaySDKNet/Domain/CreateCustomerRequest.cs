using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreateCustomerRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CreateCustomerRequest : AopObject
    {
        /// <summary>
        /// bd
        /// </summary>
        [XmlElement("bd")]
        public string Bd { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("charge_person_name")]
        public string ChargePersonName { get; set; }

        /// <summary>
        /// cid
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 客户行业
        /// </summary>
        [XmlElement("customer_industry")]
        public string CustomerIndustry { get; set; }

        /// <summary>
        /// 客户来源
        /// </summary>
        [XmlElement("customer_source")]
        public string CustomerSource { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        [XmlElement("ep_reg_no")]
        public string EpRegNo { get; set; }

        /// <summary>
        /// 经营状态
        /// </summary>
        [XmlElement("ep_status")]
        public string EpStatus { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [XmlElement("ep_type")]
        public string EpType { get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        [XmlElement("established_date")]
        public string EstablishedDate { get; set; }

        /// <summary>
        /// 行业大类
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 行业门类
        /// </summary>
        [XmlElement("industry_category")]
        public string IndustryCategory { get; set; }

        /// <summary>
        /// 所属地区
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [XmlElement("registered_address")]
        public string RegisteredAddress { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [XmlElement("registered_capital")]
        public string RegisteredCapital { get; set; }

        /// <summary>
        /// 企业人员规模
        /// </summary>
        [XmlElement("social_security_account")]
        public string SocialSecurityAccount { get; set; }
    }
}
