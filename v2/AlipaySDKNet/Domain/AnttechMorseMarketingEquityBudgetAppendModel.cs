using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingEquityBudgetAppendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingEquityBudgetAppendModel : AopObject
    {
        /// <summary>
        /// 追加金额，单位为分，必须大于0
        /// </summary>
        [XmlElement("append_amount")]
        public long AppendAmount { get; set; }

        /// <summary>
        /// 开发者可从摩斯营销计划的权益配置或权益创建结果中获取：立减权益填写对应的discountId；立减金权益填写对应的outputCampaignId。该权益必须归属于tenant_id指定的租户。
        /// </summary>
        [XmlElement("equity_id")]
        public string EquityId { get; set; }

        /// <summary>
        /// 客户业务幂等号，同一租户下全局唯一；重试必须复用原值
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 摩斯营销计划租户ID，必须与调用AppId授权的租户一致
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
