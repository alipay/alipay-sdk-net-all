using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppOperationPromoTriggerResponse.
    /// </summary>
    public class AlipayPayAppOperationPromoTriggerResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("operation_promo_list")]
        [XmlArrayItem("op_promo_info")]
        public List<OpPromoInfo> OperationPromoList { get; set; }

        /// <summary>
        /// 支付宝侧对于一次运营会话的标识，用于串联多阶段营销。
        /// </summary>
        [XmlElement("pay_operation_info")]
        public string PayOperationInfo { get; set; }
    }
}
