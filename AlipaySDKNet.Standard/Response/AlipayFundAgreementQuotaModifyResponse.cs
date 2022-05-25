using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAgreementQuotaModifyResponse.
    /// </summary>
    public class AlipayFundAgreementQuotaModifyResponse : AopResponse
    {
        /// <summary>
        /// 额度变更结果集合
        /// </summary>
        [XmlArray("quota_modify_detail_list")]
        [XmlArrayItem("quota_modify_detail")]
        public List<QuotaModifyDetail> QuotaModifyDetailList { get; set; }
    }
}
