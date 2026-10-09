using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardDataInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CardDataInfoDTO : AopObject
    {
        /// <summary>
        /// 可空，是卡片当前链接的支付宝侧id——如科室id，医生id
        /// </summary>
        [XmlElement("card_data_id")]
        public string CardDataId { get; set; }

        /// <summary>
        /// 卡片额外信息补充
        /// </summary>
        [XmlArray("card_ext_info")]
        [XmlArrayItem("card_ext_info_d_t_o")]
        public List<CardExtInfoDTO> CardExtInfo { get; set; }

        /// <summary>
        /// 用于补充描述地址之类的
        /// </summary>
        [XmlElement("card_introduce")]
        public string CardIntroduce { get; set; }

        /// <summary>
        /// 暂时不需要考虑，用于后续拓展
        /// </summary>
        [XmlArray("card_key_words")]
        [XmlArrayItem("string")]
        public List<string> CardKeyWords { get; set; }

        /// <summary>
        /// 卡片等级
        /// </summary>
        [XmlElement("card_level")]
        public string CardLevel { get; set; }

        /// <summary>
        /// 卡片单条数据logo链接
        /// </summary>
        [XmlElement("card_logo")]
        public string CardLogo { get; set; }

        /// <summary>
        /// 卡片单条数据的名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 卡片标题
        /// </summary>
        [XmlElement("card_title")]
        public string CardTitle { get; set; }

        /// <summary>
        /// 卡片中跳转链接
        /// </summary>
        [XmlElement("card_url")]
        public string CardUrl { get; set; }

        /// <summary>
        /// 卡片中数据展示顺序，从0开始，0的优先级最高
        /// </summary>
        [XmlElement("index")]
        public string Index { get; set; }

        /// <summary>
        /// 父卡片id
        /// </summary>
        [XmlElement("parent_card_id")]
        public string ParentCardId { get; set; }

        /// <summary>
        /// 父卡片名称
        /// </summary>
        [XmlElement("parent_card_name")]
        public string ParentCardName { get; set; }
    }
}
