using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncSettleSettlementbillCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncSettleSettlementbillCreateModel : AopObject
    {
        /// <summary>
        /// 结算单创建请求列表
        /// </summary>
        [XmlArray("settlement_bill_create_order")]
        [XmlArrayItem("settlement_bill_create_order")]
        public List<SettlementBillCreateOrder> SettlementBillCreateOrder { get; set; }
    }
}
