using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRebusinessentityCompanyQueryResponse.
    /// </summary>
    public class ZhimaCreditEpRebusinessentityCompanyQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业查询key
        /// </summary>
        [XmlElement("company_key")]
        public string CompanyKey { get; set; }

        /// <summary>
        /// 关系数据集
        /// </summary>
        [XmlElement("data")]
        public RebusinessEntityRelation Data { get; set; }
    }
}
