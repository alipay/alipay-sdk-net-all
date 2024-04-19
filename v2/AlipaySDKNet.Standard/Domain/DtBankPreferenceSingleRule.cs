using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankPreferenceSingleRule Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankPreferenceSingleRule : AopObject
    {
        /// <summary>
        /// 定额立减金额，单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }
    }
}
