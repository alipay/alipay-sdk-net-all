using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardOpenprocessQueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardOpenprocessQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询失败的原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 商户入驻信息
        /// </summary>
        [XmlElement("merchant_settle_in_info")]
        public MerchantSettleInInfo MerchantSettleInInfo { get; set; }

        /// <summary>
        /// 查询是否成功
        /// </summary>
        [XmlElement("query_result")]
        public bool QueryResult { get; set; }
    }
}
