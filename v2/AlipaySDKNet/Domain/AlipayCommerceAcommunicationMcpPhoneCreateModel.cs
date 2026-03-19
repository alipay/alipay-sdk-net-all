using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationMcpPhoneCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationMcpPhoneCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 需要充值的面额，单位是元。
        /// </summary>
        [XmlElement("face")]
        public string Face { get; set; }

        /// <summary>
        /// 话费最终价格，单位是元。
        /// </summary>
        [XmlElement("final_price")]
        public string FinalPrice { get; set; }

        /// <summary>
        /// 商品ID，从选品接口中拿到的商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 手机号格式
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 触发姓名验证后用户输入的姓名，可以是姓名尾字，可以是全名
        /// </summary>
        [XmlElement("mobile_name")]
        public string MobileName { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商品价格，单位是元。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 场景标识
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 触发风控校验后用户填入的短信验证码
        /// </summary>
        [XmlElement("sms_code")]
        public string SmsCode { get; set; }

        /// <summary>
        /// 商品来源（必须与询价结果中的source一致）
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 子来源标识
        /// </summary>
        [XmlElement("sub_source")]
        public string SubSource { get; set; }
    }
}
