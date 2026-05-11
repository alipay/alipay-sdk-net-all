using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundUserinfoCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundUserinfoCheckModel : AopObject
    {
        /// <summary>
        /// 业务场景码，固定值：USER_INFO_CHECK
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 按"姓名_身份证号_user_id_salt"格式拼接后，用SM3算法加密后并用Base64编码
        /// </summary>
        [XmlElement("encrypted_user_info")]
        public string EncryptedUserInfo { get; set; }

        /// <summary>
        /// 支付宝open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 产品码，固定值：BANK_TO_ALIPAY
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用于加密的随机数
        /// </summary>
        [XmlElement("salt")]
        public string Salt { get; set; }

        /// <summary>
        /// 用户支付宝UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
