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
        /// 灵工授权业务场景码，固定值：DEFAULT
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 灵工授权成功的用户支付宝登录号，与principal_id不能同时为空
        /// </summary>
        [XmlElement("principal_account_no")]
        public string PrincipalAccountNo { get; set; }

        /// <summary>
        /// 授权用户的alipayUserId，如果同时传递principal_account_no和principalId，优先通过principalId查询，与principal_account_no不能同时为空
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 灵工授权产品码，固定值：FLEXIBLE_STAFFING
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
