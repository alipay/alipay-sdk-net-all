using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalformmCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPrincipalformmCreateormodifyModel : AopObject
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
        /// 商家其他信息
        /// </summary>
        [XmlElement("extend_info")]
        public AlimamaPrincipalExtendInfo ExtendInfo { get; set; }

        /// <summary>
        /// 一级行业id
        /// </summary>
        [XmlElement("first_trade_id")]
        public string FirstTradeId { get; set; }

        /// <summary>
        /// 商家支付宝统一id
        /// </summary>
        [XmlElement("principal_oid")]
        public string PrincipalOid { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 二级行业id
        /// </summary>
        [XmlElement("second_trade_id")]
        public string SecondTradeId { get; set; }
    }
}
