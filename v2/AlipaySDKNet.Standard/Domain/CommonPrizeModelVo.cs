using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonPrizeModelVo Data Structure.
    /// </summary>
    [Serializable]
    public class CommonPrizeModelVo : AopObject
    {
        /// <summary>
        /// 奖品描述图片url
        /// </summary>
        [XmlElement("prize_desc_image_url")]
        public string PrizeDescImageUrl { get; set; }

        /// <summary>
        /// 奖品底部文案
        /// </summary>
        [XmlElement("prize_down_desc_text")]
        public string PrizeDownDescText { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }
    }
}
