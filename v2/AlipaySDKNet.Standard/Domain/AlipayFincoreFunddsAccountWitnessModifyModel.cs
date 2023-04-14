using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreFunddsAccountWitnessModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreFunddsAccountWitnessModifyModel : AopObject
    {
        /// <summary>
        /// 必填。账号,即开户时返回的asttshipcore账号。
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账户类型,ENTRUST_SUB_ACC目前仅支持子户
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 必填，操作员，调用方appname
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 签约产品码,唯一,区分资金存管服务产品类型
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 必填，账户状态，C：注销状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 必填，用户id或二级商户smid，子户维度。2088开头16位数字
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
