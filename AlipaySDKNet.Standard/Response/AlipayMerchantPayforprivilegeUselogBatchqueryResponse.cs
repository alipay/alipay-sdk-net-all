using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUselogBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUselogBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 充享惠使用记录
        /// </summary>
        [XmlArray("use_log_list")]
        [XmlArrayItem("pay_for_privilege_recharge_card_use_log")]
        public List<PayForPrivilegeRechargeCardUseLog> UseLogList { get; set; }
    }
}
