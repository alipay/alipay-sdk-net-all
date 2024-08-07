using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LlmAnswerCardDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LlmAnswerCardDTO : AopObject
    {
        /// <summary>
        /// 用于返回卡片的固定回答文本内容
        /// </summary>
        [XmlElement("card_answer")]
        public string CardAnswer { get; set; }

        /// <summary>
        /// 卡片数据
        /// </summary>
        [XmlArray("card_data")]
        [XmlArrayItem("card_data_info_d_t_o")]
        public List<CardDataInfoDTO> CardData { get; set; }

        /// <summary>
        /// 卡片类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }
    }
}
