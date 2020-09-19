using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransEntrustQueryResponse.
    /// </summary>
    public class AlipayFundTransEntrustQueryResponse : AopResponse
    {
        /// <summary>
        /// 该笔委托支付在支付宝系统内部的单据ID
        /// </summary>
        [XmlElement("entrust_order_id")]
        public string EntrustOrderId { get; set; }

        /// <summary>
        /// 商户端的唯一订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 委托扣款剩余可打款金额
        /// </summary>
        [XmlElement("rest_tranfer_amount")]
        public string RestTranferAmount { get; set; }

        /// <summary>
        /// INIT，表示委托支付单据已经受理
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 委托扣款累计扣款金额
        /// </summary>
        [XmlElement("total_deduct_amount")]
        public string TotalDeductAmount { get; set; }

        /// <summary>
        /// 委托支付订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }
    }
}
