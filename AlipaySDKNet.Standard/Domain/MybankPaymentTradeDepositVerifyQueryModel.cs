using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeDepositVerifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeDepositVerifyQueryModel : AopObject
    {
        /// <summary>
        /// 打款验证ID 打款验证受理后生成的一个唯一标识
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
