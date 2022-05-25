using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransInnovateOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransInnovateOrderQueryModel : AopObject
    {
        /// <summary>
        /// 描述特定的业务场景，如果传递了out_biz_no则该字段为必传。房租为：HOUSE_RENT
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 转账业务请求的扩展参数，格式为json格式
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 支付宝转账单据号。当和商户转账唯一订单号同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户转账唯一订单号：发起转账来源方定义的转账单据ID。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 付款方账号信息
        /// </summary>
        [XmlElement("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码，如果传递了out_biz_no则该字段为必传。可传值如下： 转账到支付宝账号 TRANSFER_TO_ALIPAY_ACCOUNT 转账到银行卡 TRANSFER_TO_BANK_CARD
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
