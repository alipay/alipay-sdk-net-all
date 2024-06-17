using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDiscountPhoneRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDiscountPhoneRecommendModel : AopObject
    {
        /// <summary>
        /// 格式是逗号分隔的字符串看，示例值中给值代表，客户端只需要5元，10元，20元，50元金额的面值的充值商品。
        /// </summary>
        [XmlElement("faces")]
        public string Faces { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝侧分配场景码，用于风控限制和商品查询
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
