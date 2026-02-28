using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterVerifyconfigQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderNpassporterVerifyconfigQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 审批单号
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 审批url
        /// </summary>
        [XmlElement("auth_url")]
        public string AuthUrl { get; set; }

        /// <summary>
        /// 授权页面配置
        /// </summary>
        [XmlElement("authorization_page_config")]
        public VerifyConfigAuthorizationPageConfig AuthorizationPageConfig { get; set; }

        /// <summary>
        /// 正常页配置
        /// </summary>
        [XmlElement("common_page_config")]
        public VerifyConfigCommonPageConfig CommonPageConfig { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 直接跳转url
        /// </summary>
        [XmlElement("location_url")]
        public string LocationUrl { get; set; }

        /// <summary>
        /// 外部唯一幂等号
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 最近一次核验配置审批描述
        /// </summary>
        [XmlElement("recent_verify_config_audit_desc")]
        public string RecentVerifyConfigAuditDesc { get; set; }

        /// <summary>
        /// 最近一次核验配置id
        /// </summary>
        [XmlElement("recent_verify_config_id")]
        public string RecentVerifyConfigId { get; set; }

        /// <summary>
        /// 最近一次核验配置状态
        /// </summary>
        [XmlElement("recent_verify_config_status")]
        public string RecentVerifyConfigStatus { get; set; }

        /// <summary>
        /// 结果页配置
        /// </summary>
        [XmlElement("result_page_config")]
        public VerifyConfigResultPageConfig ResultPageConfig { get; set; }

        /// <summary>
        /// 解决方案code
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 核验方案配置
        /// </summary>
        [XmlElement("solution_config")]
        public VerifyConfigSolutionConfig SolutionConfig { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("verify_app_id")]
        public string VerifyAppId { get; set; }

        /// <summary>
        /// 核身配置ID
        /// </summary>
        [XmlElement("verify_config_id")]
        public string VerifyConfigId { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("verify_pid")]
        public string VerifyPid { get; set; }

        /// <summary>
        /// 核验结果业来源一方或三方
        /// </summary>
        [XmlElement("verify_result_page_source")]
        public string VerifyResultPageSource { get; set; }
    }
}
