using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransEntrustQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransEntrustQueryModel : AopObject
    {
        /// <summary>
        /// 描述特定的业务场景，如果传递了out_biz_no则该字段为必传。
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 该笔委托支付在支付宝系统内部的单据ID，本参数和商户委托支付单据号不能同时为空
        /// </summary>
        [XmlElement("entrust_order_id")]
        public string EntrustOrderId { get; set; }

        /// <summary>
        /// 商户委托支付唯一订单号：发起委托支付来源方定义的单据ID。 本参数和支付宝委托单号不能同时为空。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码，如果传递了out_biz_no则该字段为必传。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
