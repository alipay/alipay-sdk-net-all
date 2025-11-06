using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantComplainReconciliationCreateResponse.
    /// </summary>
    public class AlipayMerchantComplainReconciliationCreateResponse : AopResponse
    {
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("merchant_credit_no")]
        public string MerchantCreditNo { get; set; }

        /// <summary>
        /// 商家账号信息列表
        /// </summary>
        [XmlArray("merchant_infos")]
        [XmlArrayItem("reconciliation_merchant_info")]
        public List<ReconciliationMerchantInfo> MerchantInfos { get; set; }
    }
}
