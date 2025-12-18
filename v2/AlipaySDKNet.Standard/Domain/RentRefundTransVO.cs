using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRefundTransVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentRefundTransVO : AopObject
    {
        /// <summary>
        /// 退款请求号。 标识一次退款请求，需要保证在交易号下唯一。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 资金退款时间。对齐Z50退款查询接口响应参数中的gmt_refund_pay退款时间字段。
        /// </summary>
        [XmlElement("real_refund_time")]
        public string RealRefundTime { get; set; }

        /// <summary>
        /// 退款请求的退款金额。单位：元。商户reduction扣减不包含在内
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 订单退款费用项明细列
        /// </summary>
        [XmlArray("refund_items")]
        [XmlArrayItem("rent_refund_item_v_o")]
        public List<RentRefundItemVO> RefundItems { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
