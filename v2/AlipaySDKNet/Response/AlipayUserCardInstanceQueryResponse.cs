using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCardInstanceQueryResponse.
    /// </summary>
    public class AlipayUserCardInstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// active_date：卡生效日期，yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("active_date")]
        public string ActiveDate { get; set; }

        /// <summary>
        /// balance：余额，数字格式，最多支持2位小数
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// card_status：卡状态
        /// </summary>
        [XmlElement("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// expiry_date：卡失效日期，yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("expiry_date")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// level：等级名称
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// point：积分，数字格式，最多支持2位小数
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }

        /// <summary>
        /// template_id：卡模版id，为alipay.user.card.template.create接口返回的模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
