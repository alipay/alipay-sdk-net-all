using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPageprincipalbymmQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPageprincipalbymmQueryModel : AopObject
    {
        /// <summary>
        /// 登录用户支付宝统一ID,2088开头字符串。登录校验和可反查出user_id。
        /// </summary>
        [XmlElement("alipay_oid")]
        public string AlipayOid { get; set; }

        /// <summary>
        /// 权限token,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 账户名称、账号、商户号模糊匹配
        /// </summary>
        [XmlElement("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 委托人状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
