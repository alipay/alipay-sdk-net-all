using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAutocheckCaseQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAutocheckCaseQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("biz_line_name")]
        public string BizLineName { get; set; }

        /// <summary>
        /// 小程序类型
        /// </summary>
        [XmlElement("case_type")]
        public string CaseType { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 用例描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 用例唯一主键ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlArray("labels")]
        [XmlArrayItem("string")]
        public List<string> Labels { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_version")]
        public string MiniAppVersion { get; set; }

        /// <summary>
        /// 步骤信息
        /// </summary>
        [XmlElement("step_info_list")]
        public UseCaseStepInfo StepInfoList { get; set; }

        /// <summary>
        /// 用例执行超时时间
        /// </summary>
        [XmlElement("timeout")]
        public long Timeout { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [XmlElement("use_case_name")]
        public string UseCaseName { get; set; }

        /// <summary>
        /// 用例类型
        /// </summary>
        [XmlElement("use_case_type")]
        public string UseCaseType { get; set; }
    }
}
