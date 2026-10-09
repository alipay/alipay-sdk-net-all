using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsurancePerformstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsurancePerformstatusQueryModel : AopObject
    {
        /// <summary>
        /// 保司类型，用于区分来源保险公司
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
