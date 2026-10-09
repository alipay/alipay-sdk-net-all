using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAllocSignQueryResponse.
    /// </summary>
    public class AlipayFundAllocSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 抽佣比例上限
        /// </summary>
        [XmlElement("alloc_upper_limit")]
        public string AllocUpperLimit { get; set; }

        /// <summary>
        /// 授权协议的失效时间
        /// </summary>
        [XmlElement("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 授权主体uid
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 授权主体 openId
        /// </summary>
        [XmlElement("principal_open_id")]
        public string PrincipalOpenId { get; set; }

        /// <summary>
        /// 协议状态：  SUCESS -成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支持的交易商户列表,包含 1. 商户类型：PID - 直联商户，SMID - 间联商户 2. 商户ID
        /// </summary>
        [XmlArray("support_merchant_list")]
        [XmlArrayItem("agreement_limit_merchant")]
        public List<AgreementLimitMerchant> SupportMerchantList { get; set; }

        /// <summary>
        /// 协议签约时间
        /// </summary>
        [XmlElement("valid_strat_time")]
        public string ValidStratTime { get; set; }
    }
}
