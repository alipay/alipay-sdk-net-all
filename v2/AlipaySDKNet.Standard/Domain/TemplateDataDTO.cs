using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateDataDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateDataDTO : AopObject
    {
        /// <summary>
        /// 卡片数据，卡片数据是不同卡片对象的JSONSTring字符串
        /// </summary>
        [XmlElement("card_data")]
        public string CardData { get; set; }

        /// <summary>
        /// 文本回答
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 卡片标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
