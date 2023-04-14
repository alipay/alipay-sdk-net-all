using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonPrizeVo Data Structure.
    /// </summary>
    [Serializable]
    public class CommonPrizeVo : AopObject
    {
        /// <summary>
        /// 奖品描述
        /// </summary>
        [XmlElement("prize_desc")]
        public string PrizeDesc { get; set; }

        /// <summary>
        /// 奖品图片url
        /// </summary>
        [XmlElement("prize_image_url")]
        public string PrizeImageUrl { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 该奖品的数量
        /// </summary>
        [XmlElement("prize_num")]
        public long PrizeNum { get; set; }
    }
}
