using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiFamilyInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiFamilyInfoVO : AopObject
    {
        /// <summary>
        /// 全家福已收集皮肤数量
        /// </summary>
        [XmlElement("family_count")]
        public long FamilyCount { get; set; }

        /// <summary>
        /// 全家福弹窗图片
        /// </summary>
        [XmlElement("family_img")]
        public string FamilyImg { get; set; }

        /// <summary>
        /// 全家福需要皮肤最大数量
        /// </summary>
        [XmlElement("family_max_count")]
        public long FamilyMaxCount { get; set; }

        /// <summary>
        /// 全家福状态
        /// </summary>
        [XmlElement("family_state")]
        public string FamilyState { get; set; }

        /// <summary>
        /// 全家福弹窗跳转url
        /// </summary>
        [XmlElement("family_url")]
        public string FamilyUrl { get; set; }

        /// <summary>
        /// 奖品图片地址
        /// </summary>
        [XmlElement("prize_img")]
        public string PrizeImg { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 单品id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
