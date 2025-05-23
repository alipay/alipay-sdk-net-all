using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniBaseinfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniBaseinfoQueryResponse : AopResponse
    {
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
        /// 类目名称，格式为第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目;
        /// </summary>
        [XmlElement("category_names")]
        public string CategoryNames { get; set; }

        /// <summary>
        /// 功能包名称
        /// </summary>
        [XmlArray("package_names")]
        [XmlArrayItem("string")]
        public List<string> PackageNames { get; set; }

        /// <summary>
        /// false：非受限发布；true：受限发布。 受限发布：是为了能让首次发版的小程序在备案未完成的情况下，进行上架的一种折中的操作方式，小程序可以上架可扫码进行使用，但不可被搜索、限制访问人数（50人/每天）、限制公域（无法进行商品、服务、营促销）、限制上架后90天不完成备案自动下架。
        /// </summary>
        [XmlElement("registration_limit_release")]
        public bool RegistrationLimitRelease { get; set; }

        /// <summary>
        /// 域白名单
        /// </summary>
        [XmlArray("safe_domains")]
        [XmlArrayItem("string")]
        public List<string> SafeDomains { get; set; }

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
