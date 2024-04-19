using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiQualityTestShieldTestcaseQueryResponse.
    /// </summary>
    public class KoubeiQualityTestShieldTestcaseQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试用例列表
        /// </summary>
        [XmlArray("case_list")]
        [XmlArrayItem("test_case_domain")]
        public List<TestCaseDomain> CaseList { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }
    }
}
