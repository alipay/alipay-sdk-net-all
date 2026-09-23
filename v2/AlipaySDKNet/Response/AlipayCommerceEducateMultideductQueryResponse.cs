using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateMultideductQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateMultideductQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝协议支付的协议号。OPEN时返回
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 校园支付开通状态。可选的字段枚举说明：{WAIT_SIGN_AGREEMENT:待签约协议支付;OPEN:校园支付开通;CLOSE:校园支付关闭}
        /// </summary>
        [XmlElement("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 资产信息，入参token上送的时候才会返回
        /// </summary>
        [XmlElement("asset")]
        public string Asset { get; set; }

        /// <summary>
        /// 如果有配置阈值信息，返回小荷包id，和余额是否充足
        /// </summary>
        [XmlElement("asset_info")]
        public string AssetInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 家长支付宝账户的脱敏信息（特例：特殊标识"ALREADY_RELEASED"，须通过技术支持反馈来关闭开通记录）
        /// </summary>
        [XmlElement("parent_logon_id")]
        public string ParentLogonId { get; set; }

        /// <summary>
        /// 如果是父母为孩子开通，则为父母支付宝openid；如果是用户为本人开通，则为本人支付宝openid。
        /// </summary>
        [XmlElement("parent_open_id")]
        public string ParentOpenId { get; set; }

        /// <summary>
        /// 如果是父母为孩子开通，则为父母支付宝uid；如果是用户为本人开通，则为本人支付宝uid。
        /// </summary>
        [XmlElement("parent_user_id")]
        public string ParentUserId { get; set; }

        /// <summary>
        /// 学校或教育机构内标
        /// </summary>
        [XmlElement("school_code")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 学生或教职工在学校（或教育机构）的唯一编号。使用校园支付token查询时，返回当前字段
        /// </summary>
        [XmlElement("user_unique_id")]
        public string UserUniqueId { get; set; }
    }
}
