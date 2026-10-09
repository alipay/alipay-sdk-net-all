using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitLuckDrawTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitLuckDrawTemplate : AopObject
    {
        /// <summary>
        /// 参与标识。有流水为true，反之为false。
        /// </summary>
        [XmlElement("have_participated")]
        public bool HaveParticipated { get; set; }

        /// <summary>
        /// 抽发奖流水，返回最近一笔发奖记录
        /// </summary>
        [XmlElement("play_luck_draw_order_info")]
        public BenefitOrderInfo PlayLuckDrawOrderInfo { get; set; }

        /// <summary>
        /// 抽发奖玩法模板信息
        /// </summary>
        [XmlElement("play_luck_draw_template_info")]
        public BenefitPlayLuckDrawTemplateInfo PlayLuckDrawTemplateInfo { get; set; }
    }
}
