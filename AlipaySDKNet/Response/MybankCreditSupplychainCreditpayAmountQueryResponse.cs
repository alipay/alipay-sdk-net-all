using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayAmountQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayAmountQueryResponse : AopResponse
    {
        /// <summary>
        /// 准入标志
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 可用额度
        /// </summary>
        [XmlElement("available_amt")]
        public string AvailableAmt { get; set; }

        /// <summary>
        /// 1688买家ID
        /// </summary>
        [XmlElement("buyer_scene_id")]
        public string BuyerSceneId { get; set; }

        /// <summary>
        /// 是否签约
        /// </summary>
        [XmlElement("signed")]
        public bool Signed { get; set; }

        /// <summary>
        /// 授信额度
        /// </summary>
        [XmlElement("total_amt")]
        public string TotalAmt { get; set; }

        /// <summary>
        /// Trace信息
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
