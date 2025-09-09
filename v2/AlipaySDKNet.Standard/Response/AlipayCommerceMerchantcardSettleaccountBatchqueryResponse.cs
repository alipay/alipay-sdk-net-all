using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardSettleaccountBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardSettleaccountBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 结算收款的支付宝账号,登录号，非pid
        /// </summary>
        [XmlArray("settle_alipay_logon_id_list")]
        [XmlArrayItem("string")]
        public List<string> SettleAlipayLogonIdList { get; set; }
    }
}
