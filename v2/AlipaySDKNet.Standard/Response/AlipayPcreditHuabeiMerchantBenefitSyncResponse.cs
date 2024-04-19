using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantBenefitSyncResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantBenefitSyncResponse : AopResponse
    {
        /// <summary>
        /// 业务处理结果
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
