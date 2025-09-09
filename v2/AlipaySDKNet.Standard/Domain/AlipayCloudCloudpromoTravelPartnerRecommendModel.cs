using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelPartnerRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoTravelPartnerRecommendModel : AopObject
    {
        /// <summary>
        /// 当前坐标经纬度，逗号分隔
        /// </summary>
        [XmlElement("cur_lbs_poi")]
        public string CurLbsPoi { get; set; }

        /// <summary>
        /// 伴游卡片ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// H5表示页面查询，返回较明细的信息，cube表示对话页卡片信息查询，返回仅卡片需要的缩略信息
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 外部用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
