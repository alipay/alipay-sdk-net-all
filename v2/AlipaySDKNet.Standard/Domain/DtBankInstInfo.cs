using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankInstInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankInstInfo : AopObject
    {
        /// <summary>
        /// 活动支持的银行卡类型，["CREDIT"]表示支持信用卡，["DEBIT"]表示支持借记卡，["CREDIT","DEBIT"]表示两种卡均支持。
        /// </summary>
        [XmlArray("bank_card_type_list")]
        [XmlArrayItem("string")]
        public List<string> BankCardTypeList { get; set; }

        /// <summary>
        /// 活动支持的银行名称。取值为“所有银行”表示活动支持所有银行。
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }
    }
}
