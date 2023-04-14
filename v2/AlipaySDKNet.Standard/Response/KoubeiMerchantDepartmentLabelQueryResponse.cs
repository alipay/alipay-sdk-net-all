using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentLabelQueryResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentLabelQueryResponse : AopResponse
    {
        /// <summary>
        /// 人员组织可用的部门标签列表
        /// </summary>
        [XmlArray("department_labels")]
        [XmlArrayItem("department_label")]
        public List<DepartmentLabel> DepartmentLabels { get; set; }
    }
}
