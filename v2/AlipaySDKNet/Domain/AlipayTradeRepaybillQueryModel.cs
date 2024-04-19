using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeRepaybillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeRepaybillQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝账单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单产品类型，标识业务用，具体值支付宝根据业务接入场景进行分配。
        /// </summary>
        [XmlElement("bill_product")]
        public string BillProduct { get; set; }

        /// <summary>
        /// 外部账单号
        /// </summary>
        [XmlElement("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 账单归属主体，蚂蚁统一会员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
