using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransInnovateOrderQueryResponse.
    /// </summary>
    public class AlipayFundTransInnovateOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 预计到账时间，转账到银行卡专用，格式为yyyy-MM-dd HH:mm:ss，转账受理失败不返回。 注意： 此参数为预计时间，可能与实际到账时间有较大误差，不能作为实际到账时间使用，仅供参考用途。
        /// </summary>
        [XmlElement("arrival_time_end")]
        public string ArrivalTimeEnd { get; set; }

        /// <summary>
        /// 查询到的订单状态为FAIL失败或REFUND退票时，返回错误代码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 查询到的订单状态为FAIL失败或REFUND退票时，返回具体的原因。
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 预计收费金额（元），转账到银行卡专用，数字格式，精确到小数点后2位，转账失败或转账受理失败不返回。
        /// </summary>
        [XmlElement("order_fee")]
        public string OrderFee { get; set; }

        /// <summary>
        /// 支付宝转账单据号，查询失败不返回。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付时间，格式为yyyy-MM-dd HH:mm:ss，转账失败不返回。
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("refund_date")]
        public string RefundDate { get; set; }

        /// <summary>
        /// 转账单据状态。可能出现的状态如下： SUCCESS：转账成功； WAIT_PAY：等待支付； CLOSE：订单超时关闭； FAIL：失败（适用于"单笔转账到银行卡"）； DEALING：处理中（适用于"单笔转账到银行卡"）； REFUND：退票（适用于"单笔转账到银行卡"）；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 付款金额，收银台场景下付款成功后的支付金额，订单状态为SUCCESS才返回，其他状态不返回。付款金额，单位为元，精确到小数点后两位：订单总金额，单位为元，精确到小数点后两位： 32.00
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }
    }
}
