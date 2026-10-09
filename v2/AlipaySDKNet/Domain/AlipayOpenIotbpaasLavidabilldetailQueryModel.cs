using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabilldetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotbpaasLavidabilldetailQueryModel : AopObject
    {
        /// <summary>
        /// 收款时间或者退款时间，yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("gmt_recv_pay")]
        public string GmtRecvPay { get; set; }

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
