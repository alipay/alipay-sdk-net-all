using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleQcreportUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleQcreportUploadModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("check_items")]
        [XmlArrayItem("recycle_qc_report_check_items")]
        public List<RecycleQcReportCheckItems> CheckItems { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 商户自有的质检报告地址，需要传支付宝小程序页面url，规范参考<a href="https://opendocs.alipay.com/support/01rb18">文档</a>
        /// </summary>
        [XmlElement("merchant_report_url")]
        public string MerchantReportUrl { get; set; }

        /// <summary>
        /// 支付宝用户OPENID
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 产品信息
        /// </summary>
        [XmlElement("product_info")]
        public RecycleQcReportProductInfo ProductInfo { get; set; }

        /// <summary>
        /// 报告总结
        /// </summary>
        [XmlElement("summary")]
        public RecycleQcReportSummaryInfo Summary { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
