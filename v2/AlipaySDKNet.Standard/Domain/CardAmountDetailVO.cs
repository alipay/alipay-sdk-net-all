using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardAmountDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class CardAmountDetailVO : AopObject
    {
        /// <summary>
        /// 转入金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 持卡人姓名
        /// </summary>
        [XmlElement("card_holder_name")]
        public string CardHolderName { get; set; }

        /// <summary>
        /// 转入卡账号
        /// </summary>
        [XmlElement("out_bank_card_no")]
        public string OutBankCardNo { get; set; }

        /// <summary>
        /// 转入行的银行机构id
        /// </summary>
        [XmlElement("out_bank_inst_id")]
        public string OutBankInstId { get; set; }

        /// <summary>
        /// 转入行的银行名称
        /// </summary>
        [XmlElement("out_bank_name")]
        public string OutBankName { get; set; }
    }
}
