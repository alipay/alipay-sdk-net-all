using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignClosePreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloansignClosePreconsultModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id，客户在支付宝的身份证
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 扩展信息，预留字段
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 标准蚂蚁借贷款产品
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// // 主动退出 MANUAL,  // 支付宝解换绑退出 ALIPAY_UNBIND,  // 淘宝注销 TAOBAO_LOGOUT
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
