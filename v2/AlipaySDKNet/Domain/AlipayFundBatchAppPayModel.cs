using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundBatchAppPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundBatchAppPayModel : AopObject
    {
        /// <summary>
        /// 支付宝内部批次号
        /// </summary>
        [XmlElement("batch_trans_id")]
        public string BatchTransId { get; set; }
    }
}
