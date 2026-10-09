using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecialCardInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class SpecialCardInfoModel : AopObject
    {
        /// <summary>
        /// 按钮的跳转链接
        /// </summary>
        [XmlElement("action_link")]
        public string ActionLink { get; set; }

        /// <summary>
        /// 点击的按钮文案
        /// </summary>
        [XmlElement("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 描述是否可用信息
        /// </summary>
        [XmlElement("card_business_types_full_name")]
        public string CardBusinessTypesFullName { get; set; }

        /// <summary>
        /// 描述卡片业务类型
        /// </summary>
        [XmlArray("card_business_types_key")]
        [XmlArrayItem("string")]
        public List<string> CardBusinessTypesKey { get; set; }

        /// <summary>
        /// 卡片的描述信息
        /// </summary>
        [XmlElement("card_desc")]
        public string CardDesc { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡标题信息
        /// </summary>
        [XmlElement("card_title")]
        public string CardTitle { get; set; }

        /// <summary>
        /// 卡类型参数
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 不同用户特种码的不同状态类型
        /// </summary>
        [XmlElement("code_status")]
        public string CodeStatus { get; set; }

        /// <summary>
        /// 用来描述已经认证的特种类型
        /// </summary>
        [XmlArray("effective_dentification_types")]
        [XmlArrayItem("string")]
        public List<string> EffectiveDentificationTypes { get; set; }

        /// <summary>
        /// 卡面链接
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }
    }
}
