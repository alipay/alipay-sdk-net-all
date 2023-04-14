using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreFunddsAccountWitnessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreFunddsAccountWitnessQueryModel : AopObject
    {
        /// <summary>
        /// 监管户不需要填写,子户必填，账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账户类型,支持监管户(SUPERVISED_ACC)和子户(ENTRUST_SUB_ACC)
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 签约产品码,唯一,区分资金存管服务产品类型
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 监管户不需要填写,子户必填。 蚂蚁统一会员ID,用户id或二级商户smid，子户维度。2088开头16位数字。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
