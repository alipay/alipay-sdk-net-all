using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NDeliveryDisplayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NDeliveryDisplayInfo : AopObject
    {
        /// <summary>
        /// 枚举值： OPEN_DAILY_OPERATION：日常运营模版 OPEN_SALES_PROMOTION：活动促销模版 OPEN_FESTIVE_ATMOSPHERE：节日氛围模版 模板示例见：接入指南-碰一下支付成功页卡片视觉风格
        /// </summary>
        [XmlElement("card_visual_style")]
        public string CardVisualStyle { get; set; }

        /// <summary>
        /// 在碰一下支付成功页卡片上展示的主标题
        /// </summary>
        [XmlElement("main_title")]
        public string MainTitle { get; set; }

        /// <summary>
        /// 在碰一下支付成功页卡片上展示的副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }
    }
}
