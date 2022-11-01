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
    }
}
