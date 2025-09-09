using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseQuotaQueryResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseQuotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 芝麻总额度
        /// </summary>
        [XmlElement("total_quota")]
        public CreditMoney TotalQuota { get; set; }
    }
}
