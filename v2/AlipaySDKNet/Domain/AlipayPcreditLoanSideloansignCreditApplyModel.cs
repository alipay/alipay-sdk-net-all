using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignCreditApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloansignCreditApplyModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id，客户在支付宝的身份证
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 授信申请编号，唯一单号，业务幂等键
        /// </summary>
        [XmlElement("credit_apply_no")]
        public string CreditApplyNo { get; set; }

        /// <summary>
        /// 淘宝会员id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 当前淘宝提供的接口文档里面设定的扩展信息 承载在咨询阶段返回的需要透传回传给蚂蚁的信息 合并取协议曝光的返回结果contractSignCacheKey
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 授信申请机构
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

        /// <summary>
        /// 大安全核身id
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
