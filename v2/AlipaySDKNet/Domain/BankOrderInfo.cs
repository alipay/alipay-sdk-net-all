using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BankOrderInfo : AopObject
    {
        /// <summary>
        /// 银行的转账流水号，来账通知时平台基于该字段进行交易匹配
        /// </summary>
        [XmlElement("bank_serial_no")]
        public string BankSerialNo { get; set; }

        /// <summary>
        /// 资方内部转账流水号
        /// </summary>
        [XmlElement("capital_serial_no")]
        public string CapitalSerialNo { get; set; }
    }
}
