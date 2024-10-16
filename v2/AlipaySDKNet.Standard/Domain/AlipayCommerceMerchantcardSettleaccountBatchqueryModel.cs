using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardSettleaccountBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardSettleaccountBatchqueryModel : AopObject
    {
        /// <summary>
        /// 次卡周期卡场景下，用到了代扣的能力，所以需要support_deduct=true，过滤掉不支持代扣的账号
        /// </summary>
        [XmlElement("support_deduct")]
        public bool SupportDeduct { get; set; }
    }
}
