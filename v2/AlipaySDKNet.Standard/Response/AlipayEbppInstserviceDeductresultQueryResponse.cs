using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductresultQueryResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 单位：元
        /// </summary>
        [XmlElement("deduct_amount")]
        public string DeductAmount { get; set; }

        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("order_result_code")]
        public string OrderResultCode { get; set; }

        /// <summary>
        /// 返回的结果码描述
        /// </summary>
        [XmlElement("order_result_msg")]
        public string OrderResultMsg { get; set; }

        /// <summary>
        /// 上送流水号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 时间格式：yyyyMMddHHmmss
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 0:未知状态 1:支付成功 2:支付失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
