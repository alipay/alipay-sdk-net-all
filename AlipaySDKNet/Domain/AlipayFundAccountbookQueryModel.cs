using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountbookQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountbookQueryModel : AopObject
    {
        /// <summary>
        /// 记账账簿id
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户会员的唯一标识，如果传入account_book_id此字段必传并比对一致性。
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 资金记账本的开通场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
