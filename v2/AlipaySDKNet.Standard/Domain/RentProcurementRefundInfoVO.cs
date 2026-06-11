using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentProcurementRefundInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentProcurementRefundInfoVO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pay_items")]
        [XmlArrayItem("rent_procurement_pay_item_info_v_o")]
        public List<RentProcurementPayItemInfoVO> PayItems { get; set; }

        /// <summary>
        /// 退款总金额，单位：元，精确到小数点后两位 说明：退款总金额= sum{refund_items（退款金额）}-sum{pay_items （支付费用金额）}
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("refund_items")]
        [XmlArrayItem("rent_procurement_pay_item_info_v_o")]
        public List<RentProcurementPayItemInfoVO> RefundItems { get; set; }
    }
}
