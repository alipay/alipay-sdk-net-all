using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftSkuBenefitNotifyResponse.
    /// </summary>
    public class AnttechNftSkuBenefitNotifyResponse : AopResponse
    {
        /// <summary>
        /// 已处理
        /// </summary>
        [XmlElement("state")]
        public bool State { get; set; }
    }
}
