using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorBankCardDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorBankCardDTO : AopObject
    {
        /// <summary>
        /// 支付宝绑卡唯一id
        /// </summary>
        [XmlElement("bank_contract_id")]
        public string BankContractId { get; set; }

        /// <summary>
        /// 银行id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 展示的银行名称缩写
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 展示的脱敏卡号后四位
        /// </summary>
        [XmlElement("show_card_no")]
        public string ShowCardNo { get; set; }
    }
}
