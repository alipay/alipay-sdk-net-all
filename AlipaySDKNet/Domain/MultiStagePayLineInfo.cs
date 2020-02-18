using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiStagePayLineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MultiStagePayLineInfo : AopObject
    {
        /// <summary>
        /// 多次支付中的1次支付金额
        /// </summary>
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 描述分次支付中某一次支付的信息，这个字段标识”次“的数字标识，从0开始；
        /// </summary>
        [XmlElement("payment_idx")]
        public long PaymentIdx { get; set; }
    }
}
