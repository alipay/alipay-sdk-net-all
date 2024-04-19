using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinancePfApplySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinancePfApplySendModel : AopObject
    {
        /// <summary>
        /// 融资支用申请业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 资金渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 支用申请标识
        /// </summary>
        [XmlElement("financing_id")]
        public string FinancingId { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [XmlElement("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 平台标识
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }
    }
}
