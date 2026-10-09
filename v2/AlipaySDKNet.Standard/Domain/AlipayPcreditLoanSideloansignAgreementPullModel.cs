using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignAgreementPullModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloansignAgreementPullModel : AopObject
    {
        /// <summary>
        /// 信贷业务场景类型Code
        /// </summary>
        [XmlElement("agreement_type")]
        public string AgreementType { get; set; }

        /// <summary>
        /// 支付宝用户id，客户在支付宝的身份证
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 授信类型
        /// </summary>
        [XmlElement("credit_type")]
        public string CreditType { get; set; }

        /// <summary>
        /// 传入拉取代签协议列表前, 扩展信息透传相关业务场景的咨询结果信息
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 授信机构Id
        /// </summary>
        [XmlElement("fund_supplier_code")]
        public string FundSupplierCode { get; set; }

        /// <summary>
        /// 授信机构id列表
        /// </summary>
        [XmlArray("fund_supplier_code_list")]
        [XmlArrayItem("string")]
        public List<string> FundSupplierCodeList { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁借贷款产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 子授信模式，目前仅在签支合一的情况下传入
        /// </summary>
        [XmlElement("sub_credit_type")]
        public string SubCreditType { get; set; }
    }
}
