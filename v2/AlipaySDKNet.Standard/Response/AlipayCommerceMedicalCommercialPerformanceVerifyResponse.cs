using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialPerformanceVerifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialPerformanceVerifyResponse : AopResponse
    {
        /// <summary>
        /// biz_order_id用于标识支付宝侧唯一业务单的id，在商户核销用户商品时返回给商户。
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// out_biz_no为外部唯一业务号，在用户核销商品时外部机构生成并调用核销接口，该字段用于幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// out_product_id为商户侧的商品id，用户商户侧唯一标记一个商户商品id。
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// verify_result表示核销状态，返回当前商品核销成功（SUCCESS）还是失败（FAIL）
        /// </summary>
        [XmlElement("verify_result")]
        public string VerifyResult { get; set; }
    }
}
