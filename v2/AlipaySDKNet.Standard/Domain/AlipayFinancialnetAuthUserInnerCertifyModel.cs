using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthUserInnerCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthUserInnerCertifyModel : AopObject
    {
        /// <summary>
        /// 浙江省杭州市地区编码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 传入外部商户的名称即可，记录发起认证的用户来自哪一个外部商户
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
