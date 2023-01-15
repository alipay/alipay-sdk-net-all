using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingAuthorizeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingAuthorizeQueryModel : AopObject
    {
        /// <summary>
        /// 灵工授权业务场景码，默认：DEFAULT。使用独立授权资产产品时，传递AUTHORIZE
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 【已废弃字段】灵工授权成功的用户支付宝登录号
        /// </summary>
        [XmlElement("principal_account_no")]
        public string PrincipalAccountNo { get; set; }

        /// <summary>
        /// 授权用户的主体Id，与pirincipal_type组合使用。
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 授权人名称
        /// </summary>
        [XmlElement("principal_name")]
        public string PrincipalName { get; set; }

        /// <summary>
        /// 授权主体类型
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 灵工授权产品码，固定值：FLEXIBLE_STAFFING
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
