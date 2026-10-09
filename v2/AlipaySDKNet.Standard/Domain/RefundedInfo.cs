using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundedInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RefundedInfo : AopObject
    {
        /// <summary>
        /// 用户申请订单号回传。 Unique Application No.
        /// </summary>
        [XmlElement("application_no")]
        public string ApplicationNo { get; set; }

        /// <summary>
        /// 签证费
        /// </summary>
        [XmlElement("evoa_fee_amount")]
        public string EvoaFeeAmount { get; set; }

        /// <summary>
        /// 处理人姓名
        /// </summary>
        [XmlElement("process_by")]
        public string ProcessBy { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        [XmlElement("process_date_time")]
        public string ProcessDateTime { get; set; }

        /// <summary>
        /// 处理附加信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 签证服务费用价格
        /// </summary>
        [XmlElement("service_fee_amount")]
        public string ServiceFeeAmount { get; set; }

        /// <summary>
        /// 退款受理状态：Checked/Approved/Rejected
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商户交易号。 VOA NO.
        /// </summary>
        [XmlElement("voa_no")]
        public string VoaNo { get; set; }
    }
}
