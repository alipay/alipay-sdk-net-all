using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignSealAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthEcsignSealAuthModel : AopObject
    {
        /// <summary>
        /// 经过认证的支付宝账号
        /// </summary>
        [XmlElement("auth_alipay_no")]
        public string AuthAlipayNo { get; set; }

        /// <summary>
        /// 授权结束时间，只计算年月日。
        /// </summary>
        [XmlElement("auth_end_date")]
        public string AuthEndDate { get; set; }

        /// <summary>
        /// 授权开始时间，只计算年月日。
        /// </summary>
        [XmlElement("auth_start_date")]
        public string AuthStartDate { get; set; }

        /// <summary>
        /// 印章ID，唯一值。
        /// </summary>
        [XmlElement("seal_id")]
        public string SealId { get; set; }
    }
}
