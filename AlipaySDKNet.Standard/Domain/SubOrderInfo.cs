using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubOrderInfo : AopObject
    {
        /// <summary>
        /// 账期
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [XmlElement("billkey")]
        public string Billkey { get; set; }

        /// <summary>
        /// 出账机构
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 子订单状态: I-等待付款 P-已支付 C-单据关闭  F-失败  S-成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 水费：WATER 电费：ELECTRIC 燃气费：GAS 暖气费：HEATING 有限电视：CATV 固话和宽带都是：COMMUN
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 子订单流水号
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }
    }
}
