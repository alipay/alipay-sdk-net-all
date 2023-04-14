using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyFinleaseTokenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyFinleaseTokenQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 业务内容
        /// </summary>
        [XmlElement("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 业务场景(MY_BANK_WITH_HOLD:网商受托代扣)
        /// </summary>
        [XmlElement("biz_sence")]
        public string BizSence { get; set; }

        /// <summary>
        /// 商户ipid
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 商户ipRoleId
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 商户统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("option_type")]
        public string OptionType { get; set; }

        /// <summary>
        /// 请求时间
        /// </summary>
        [XmlElement("request_date")]
        public string RequestDate { get; set; }

        /// <summary>
        /// 幂等号，不能重复
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
