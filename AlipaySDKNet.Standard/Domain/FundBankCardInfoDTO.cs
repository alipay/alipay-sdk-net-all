using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundBankCardInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FundBankCardInfoDTO : AopObject
    {
        /// <summary>
        /// 银行卡号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 发卡行
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行卡户名
        /// </summary>
        [XmlElement("inst_account_name")]
        public string InstAccountName { get; set; }

        /// <summary>
        /// 机构编码，点此下载 <a href="https://gw.alipayobjects.com/os/bmw-prod/bb7b3928-e012-41f2-98bb-13b1ff4a76a8.xlsx" target="_blank" rel="noopener noreferrer"><span>常见机构编码.xlsx</span></a>。
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
