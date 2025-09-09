using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorRepayApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorRepayApplyResponse : AopResponse
    {
        /// <summary>
        /// 订单信息 (用于拉起收银台付款)，JSON格式，成功时返回
        /// </summary>
        [XmlElement("order_info")]
        public string OrderInfo { get; set; }

        /// <summary>
        /// 还款交易流水号 (提交还款成功时返回)
        /// </summary>
        [XmlElement("out_repay_no")]
        public string OutRepayNo { get; set; }

        /// <summary>
        /// 拒绝原因码 0-表示提交还款成功。result_code=0时必填
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝原因说明（失败必传）
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }
    }
}
