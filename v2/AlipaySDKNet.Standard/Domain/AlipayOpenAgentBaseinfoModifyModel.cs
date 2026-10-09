using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAgentBaseinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentBaseinfoModifyModel : AopObject
    {
        /// <summary>
        /// 智能体应用描述
        /// </summary>
        [XmlElement("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("app_label")]
        [XmlArrayItem("string")]
        public List<string> AppLabel { get; set; }

        /// <summary>
        /// 智能体应用logo，建议上传像素为 200*200 ，小于200kb的图标。
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 智能体应用名称。名称长度为3-30个字符，一个中文字等于2个字符，名称可以由中文、数字、英文、下划线、+、-组成。
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 选择智能体的发音人
        /// </summary>
        [XmlElement("app_tone")]
        public string AppTone { get; set; }

        /// <summary>
        /// 对话页的背景图片，建议像素为750x1624，小于500kb的图片
        /// </summary>
        [XmlElement("background")]
        public string Background { get; set; }

        /// <summary>
        /// 底部输入框指引
        /// </summary>
        [XmlElement("card_bottom")]
        public string CardBottom { get; set; }

        /// <summary>
        /// 进入智能体的开场白
        /// </summary>
        [XmlElement("card_guide")]
        public string CardGuide { get; set; }

        /// <summary>
        /// 推荐问题，当card_type为FUNCTIONAL_CARD是为必填
        /// </summary>
        [XmlElement("card_recommend")]
        public RecommendQuestion CardRecommend { get; set; }

        /// <summary>
        /// 选择智能体开场展现的类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 是否开启继续问
        /// </summary>
        [XmlElement("continue_ask")]
        public bool ContinueAsk { get; set; }

        /// <summary>
        /// 自定卡片内容，当card_type为CUSTOM_CARD时需要填写。
        /// </summary>
        [XmlElement("custom_card")]
        public CustomCard CustomCard { get; set; }

        /// <summary>
        /// 自定义卡片body，选择自定义卡片时需要填写
        /// </summary>
        [XmlElement("custom_card_body")]
        public string CustomCardBody { get; set; }

        /// <summary>
        /// 自定义卡片ID，选择自定义卡片时需要填写
        /// </summary>
        [XmlElement("custom_card_id")]
        public string CustomCardId { get; set; }

        /// <summary>
        /// 默认问答模式，必须在support_qa_mode列表里面
        /// </summary>
        [XmlElement("default_qa_mode")]
        public string DefaultQaMode { get; set; }

        /// <summary>
        /// 引导问题，当card_type为LEADING_TEXT_DEFAULT_CARD(默认文本卡片)或EXPERT_CARD(专家智能体卡片)时支持修改引导语，最大支持3条。
        /// </summary>
        [XmlElement("leading_questions")]
        public string LeadingQuestions { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("support_qa_mode")]
        [XmlArrayItem("string")]
        public List<string> SupportQaMode { get; set; }
    }
}
