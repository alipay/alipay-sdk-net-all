using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BillInfo : AopObject
    {
        /// <summary>
        /// 收款时间或者退款时间
        /// </summary>
        [XmlElement("gmt_recv_pay")]
        public string GmtRecvPay { get; set; }

        /// <summary>
        /// 交易收款金额
        /// </summary>
        [XmlElement("recv_pay_amt")]
        public string RecvPayAmt { get; set; }

        /// <summary>
        /// 收支单据号
        /// </summary>
        [XmlElement("rp_record_id")]
        public string RpRecordId { get; set; }

        /// <summary>
        /// 收支类型，1：交易收款；2：交易退款
        /// </summary>
        [XmlElement("rp_record_type")]
        public long RpRecordType { get; set; }
    }
}
