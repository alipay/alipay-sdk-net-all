using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfexportMerchantbillQueryResponse.
    /// </summary>
    public class AlipayEbppJfexportMerchantbillQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付的总金额。单位为：RMB元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 账期
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 支付宝的业务订单号，具有唯一性和幂等性
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务类型英文名称
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构英文简称
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 拓展字段，json串(key-value对)
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 外部商户的业务流水号，需要保证唯一性和幂等性
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 账单拥有者的姓名
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 账单的状态，I-等待付款，P-处理中，已扣款待销账，C-单据关闭，F-失败，W-清算后退款，S-销账成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子业务类型英文名称
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
