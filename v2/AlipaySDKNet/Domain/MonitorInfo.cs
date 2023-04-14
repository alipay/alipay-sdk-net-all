using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MonitorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MonitorInfo : AopObject
    {
        /// <summary>
        /// 监管户名
        /// </summary>
        [XmlElement("monitor_account_name")]
        public string MonitorAccountName { get; set; }

        /// <summary>
        /// 监管户号
        /// </summary>
        [XmlElement("monitor_account_no")]
        public string MonitorAccountNo { get; set; }

        /// <summary>
        /// 监管户所在银行联行号
        /// </summary>
        [XmlElement("monitor_bank_code")]
        public string MonitorBankCode { get; set; }
    }
}
