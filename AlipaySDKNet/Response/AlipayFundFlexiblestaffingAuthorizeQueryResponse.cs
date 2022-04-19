using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingAuthorizeQueryResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingAuthorizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("authorize_time")]
        public string AuthorizeTime { get; set; }

        /// <summary>
        /// 授服务的企业名称
        /// </summary>
        [XmlElement("authorized_party_name")]
        public string AuthorizedPartyName { get; set; }

        /// <summary>
        /// 灵工授权业务场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 授权主体的支付宝账户ID
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 灵工授权产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 灵工授权状态，有限枚举。1.VALID
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
