using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterVerifyconfigCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpassporterVerifyconfigCreateModel : AopObject
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 授权页面配置
        /// </summary>
        [XmlElement("authorization_page_config")]
        public AuthorizationPageConfig AuthorizationPageConfig { get; set; }

        /// <summary>
        /// 通用页面配置
        /// </summary>
        [XmlElement("common_page_config")]
        public CommonPageConfig CommonPageConfig { get; set; }

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
        /// 结果页配置
        /// </summary>
        [XmlElement("result_page_config")]
        public ResultPageConfig ResultPageConfig { get; set; }

        /// <summary>
        /// 解决方案类型
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 解决方案配置
        /// </summary>
        [XmlElement("solution_config")]
        public SolutionConfig SolutionConfig { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("verify_app_id")]
        public string VerifyAppId { get; set; }

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
