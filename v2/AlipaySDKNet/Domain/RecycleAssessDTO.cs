using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleAssessDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleAssessDTO : AopObject
    {
        /// <summary>
        /// 估价单id
        /// </summary>
        [XmlElement("estimate_bill_id")]
        public string EstimateBillId { get; set; }

        /// <summary>
        /// 估价结果id
        /// </summary>
        [XmlElement("estimate_result_id")]
        public string EstimateResultId { get; set; }

        /// <summary>
        /// 回收商信息
        /// </summary>
        [XmlElement("merchant_info")]
        public RecycleMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 价格列表
        /// </summary>
        [XmlArray("price_info_list")]
        [XmlArrayItem("recycle_price_info")]
        public List<RecyclePriceInfo> PriceInfoList { get; set; }

        /// <summary>
        /// 价格类型
        /// </summary>
        [XmlElement("price_type")]
        public string PriceType { get; set; }
    }
}
