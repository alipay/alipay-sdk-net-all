using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundMbpcardCardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundMbpcardCardQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_identity_id")]
        public string AlipayIdentityId { get; set; }

        /// <summary>
        /// 会员ID:ALIPAY_USER_ID 会员登陆ID:ALIPAY_LOGON_ID
        /// </summary>
        [XmlElement("alipay_identity_type")]
        public string AlipayIdentityType { get; set; }

        /// <summary>
        /// 卡片绑定人姓名
        /// </summary>
        [XmlElement("bind_user_name")]
        public string BindUserName { get; set; }

        /// <summary>
        /// 指定查询卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
