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
        /// 申请状态列表
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
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 支付宝商户ID列表
        /// </summary>
        [XmlArray("merchant_id")]
        [XmlArrayItem("string")]
        public List<string> MerchantId { get; set; }
    }
}
