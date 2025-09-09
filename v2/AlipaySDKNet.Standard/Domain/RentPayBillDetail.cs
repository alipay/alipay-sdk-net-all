using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayBillDetail : AopObject
    {
        /// <summary>
        /// 租房账单时间
        /// </summary>
        [XmlElement("bill_time")]
        public string BillTime { get; set; }

        /// <summary>
        /// 租房账单中的押金费用，单位：元
        /// </summary>
        [XmlElement("deposit_fee")]
        public string DepositFee { get; set; }

        /// <summary>
        /// 其他费用，单位: 元
        /// </summary>
        [XmlElement("other_fee")]
        public string OtherFee { get; set; }

        /// <summary>
        /// 当前账期的租金费用，单位：元
        /// </summary>
        [XmlElement("rent_fee")]
        public string RentFee { get; set; }

        /// <summary>
        /// 租房平台房源租赁账单标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 租房总金额，单位：元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
