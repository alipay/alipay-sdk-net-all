using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomCard Data Structure.
    /// </summary>
    [Serializable]
    public class CustomCard : AopObject
    {
        /// <summary>
        /// 自定义卡片body，选择自定义卡片时需要填写
        /// </summary>
        [XmlElement("card_body")]
        public string CardBody { get; set; }

        /// <summary>
        /// 自定义卡片ID，选择自定义卡片时需要填写
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }
    }
}
