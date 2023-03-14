using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAutocheckCaseCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAutocheckCaseCreateModel : AopObject
    {
        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("biz_line_name")]
        public string BizLineName { get; set; }

        /// <summary>
        /// 用例执行时的小程序类型
        /// </summary>
        [XmlElement("case_app_type")]
        public string CaseAppType { get; set; }

        /// <summary>
        /// slm上的用例ID，在用例类型为脚本时必填，多个用例ID之间用,分割
        /// </summary>
        [XmlElement("case_ids")]
        public string CaseIds { get; set; }

        /// <summary>
        /// 针对用例进行描述
        /// </summary>
        [XmlElement("case_intro")]
        public string CaseIntro { get; set; }

        /// <summary>
        /// 用例名称，确保唯一，不可重复
        /// </summary>
        [XmlElement("case_name")]
        public string CaseName { get; set; }

        /// <summary>
        /// 步骤信息
        /// </summary>
        [XmlArray("case_step_models")]
        [XmlArrayItem("use_case_step_info")]
        public List<UseCaseStepInfo> CaseStepModels { get; set; }

        /// <summary>
        /// 用例的创建人，传创建人工号
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 用例执行的超时时间
        /// </summary>
        [XmlElement("time_out")]
        public string TimeOut { get; set; }

        /// <summary>
        /// slm脚本用例中使用到的参数
        /// </summary>
        [XmlElement("use_case_exe_map")]
        public string UseCaseExeMap { get; set; }

        /// <summary>
        /// 用例类型
        /// </summary>
        [XmlElement("use_case_type")]
        public string UseCaseType { get; set; }
    }
}
