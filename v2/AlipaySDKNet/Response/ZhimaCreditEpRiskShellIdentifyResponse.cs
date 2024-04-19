using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRiskShellIdentifyResponse.
    /// </summary>
    public class ZhimaCreditEpRiskShellIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 空壳企业特征集合
        /// </summary>
        [XmlArray("shell_company_features")]
        [XmlArrayItem("shell_company_feature_detail")]
        public List<ShellCompanyFeatureDetail> ShellCompanyFeatures { get; set; }

        /// <summary>
        /// 空壳企业 工商变更 集合
        /// </summary>
        [XmlArray("shell_company_gs_changes")]
        [XmlArrayItem("shell_company_gs_change_detail")]
        public List<ShellCompanyGsChangeDetail> ShellCompanyGsChanges { get; set; }
    }
}
