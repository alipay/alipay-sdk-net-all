using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeMerchantCreditModifyResponse.
    /// </summary>
    public class AlipayTradeMerchantCreditModifyResponse : AopResponse
    {
        /// <summary>
        /// 当前最大信用额度
        /// </summary>
        [XmlElement("current_credit_quota")]
        public string CurrentCreditQuota { get; set; }

        /// <summary>
        /// 卖家已经授权拆分给到买家的赊账额度
        /// </summary>
        [XmlElement("granted_credit_quota")]
        public string GrantedCreditQuota { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
