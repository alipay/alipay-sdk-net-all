using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierCompanyoverviewQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierCompanyoverviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁企业信用一分钟知企业数据
        /// </summary>
        [XmlElement("company_overview_info")]
        public CompanyOverviewInfo CompanyOverviewInfo { get; set; }
    }
}
