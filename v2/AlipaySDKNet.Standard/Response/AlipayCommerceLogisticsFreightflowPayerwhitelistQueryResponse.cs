using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowPayerwhitelistQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowPayerwhitelistQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("allowed_account_white_list")]
        [XmlArrayItem("freight_flow_allowed_account")]
        public List<FreightFlowAllowedAccount> AllowedAccountWhiteList { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 银行管理模式 ANT_MYBANK(网商银行模式); SPDB(浦发银行)
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 归属人唯一标识: 当归属人类型为子户时代表子户卡号
        /// </summary>
        [XmlElement("owner_account_no")]
        public string OwnerAccountNo { get; set; }

        /// <summary>
        /// 归属人类型： SUB_ACCOUNT(子户)
        /// </summary>
        [XmlElement("owner_account_type")]
        public string OwnerAccountType { get; set; }

        /// <summary>
        /// 业务场景: DEPOSIT_NOTIFY(入金通知)
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
