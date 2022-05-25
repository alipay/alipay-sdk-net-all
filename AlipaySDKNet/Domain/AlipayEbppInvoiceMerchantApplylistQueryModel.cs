using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantApplylistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceMerchantApplylistQueryModel : AopObject
    {
        /// <summary>
        /// 申请状态列表，期望拉取的状态。 申请状态，可选值： waiting_pull：待拉取 ; apply_success: 申请成功； inv_success: 开票成功； inv_fail：开票失败；
        /// </summary>
        [XmlArray("apply_status")]
        [XmlArrayItem("string")]
        public List<string> ApplyStatus { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("biz_end_time")]
        public string BizEndTime { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [XmlElement("biz_start_time")]
        public string BizStartTime { get; set; }

        /// <summary>
        /// 品牌名称，全局唯一，接入时约定
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 支付宝商户id
        /// </summary>
        [XmlArray("merchant_id")]
        [XmlArrayItem("string")]
        public List<string> MerchantId { get; set; }
    }
}
