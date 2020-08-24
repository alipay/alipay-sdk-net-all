using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountbookCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountbookCreateModel : AopObject
    {
        /// <summary>
        /// JSON格式，传递业务扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部商户系统会员的唯一标识
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 外部商户用户类型:BUSINESS_EMPLOYEE
        /// </summary>
        [XmlElement("merchant_user_type")]
        public string MerchantUserType { get; set; }

        /// <summary>
        /// 资金记账本的业务场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
