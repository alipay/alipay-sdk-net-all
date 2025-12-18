using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EstimateSupplyBill Data Structure.
    /// </summary>
    [Serializable]
    public class EstimateSupplyBill : AopObject
    {
        /// <summary>
        /// 优惠金额，单位分
        /// </summary>
        [XmlElement("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// 费用明细对象列表
        /// </summary>
        [XmlArray("fee_item_list")]
        [XmlArrayItem("bill_fee_item")]
        public List<BillFeeItem> FeeItemList { get; set; }

        /// <summary>
        /// 支付金额，单位分 totalAmount - discountAmount = payAmount
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 预估总费用，单位分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }
    }
}
