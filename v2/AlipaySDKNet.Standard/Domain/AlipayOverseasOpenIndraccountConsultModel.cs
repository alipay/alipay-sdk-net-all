using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndraccountConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndraccountConsultModel : AopObject
    {
        /// <summary>
        /// 账户名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 行业缴费账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 银行代码包括： 美国银行abafw号 （aba/fw） 英国收款银行清算号(sort_code) 澳大利亚收款银行清算号(bsb_code) 加拿大收款银行清算号(cc_code)
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 收款方id
        /// </summary>
        [XmlElement("beneficiary_id")]
        public string BeneficiaryId { get; set; }

        /// <summary>
        /// 国家，ISO3166标准2位国家码
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 收款类型
        /// </summary>
        [XmlElement("receipt_method")]
        public string ReceiptMethod { get; set; }

        /// <summary>
        /// 场景类型: TUITION 留学缴费 HOUSE_RENTAL 留学租房
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// Swift Code
        /// </summary>
        [XmlElement("swift_code")]
        public string SwiftCode { get; set; }
    }
}
