using System;
using System.Xml.Serialization;

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
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁借贷款产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
