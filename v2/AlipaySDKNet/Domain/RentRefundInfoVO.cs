using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRefundInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentRefundInfoVO : AopObject
    {
        /// <summary>
        /// 支付创建时传入的商户外部交易ID
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付订单的支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付后退款流水信息
        /// </summary>
        [XmlArray("rent_refund_trans_infos")]
        [XmlArrayItem("rent_refund_trans_v_o")]
        public List<RentRefundTransVO> RentRefundTransInfos { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
