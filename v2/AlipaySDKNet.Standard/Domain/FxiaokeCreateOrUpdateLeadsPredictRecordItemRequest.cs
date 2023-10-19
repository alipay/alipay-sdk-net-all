using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FxiaokeCreateOrUpdateLeadsPredictRecordItemRequest Data Structure.
    /// </summary>
    [Serializable]
    public class FxiaokeCreateOrUpdateLeadsPredictRecordItemRequest : AopObject
    {
        /// <summary>
        /// 商品类目code
        /// </summary>
        [XmlElement("commodity_cate_code")]
        public string CommodityCateCode { get; set; }

        /// <summary>
        /// 产品金额元
        /// </summary>
        [XmlElement("contract_amount")]
        public string ContractAmount { get; set; }

        /// <summary>
        /// 软件订阅年限
        /// </summary>
        [XmlElement("software_subscription_years")]
        public string SoftwareSubscriptionYears { get; set; }
    }
}
