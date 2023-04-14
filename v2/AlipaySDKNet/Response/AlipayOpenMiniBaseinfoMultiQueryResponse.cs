using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniBaseinfoMultiQueryResponse.
    /// </summary>
    public class AlipayOpenMiniBaseinfoMultiQueryResponse : AopResponse
    {
        /// <summary>
        /// 01:企业 06：个人
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 小程序应用描述
        /// </summary>
        [XmlElement("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称
        /// </summary>
        [XmlElement("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序应用logo图标
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        [XmlElement("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 所在地址
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 企业执照注册号
        /// </summary>
        [XmlElement("business_license_no")]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// 类目名称，格式为第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目;
        /// </summary>
        [XmlElement("category_names")]
        public string CategoryNames { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 小程序客服邮箱
        /// </summary>
        [XmlElement("service_email")]
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }
    }
}
