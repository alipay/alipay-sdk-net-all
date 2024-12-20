using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoPartnerAllpoiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoPartnerAllpoiQueryModel : AopObject
    {
        /// <summary>
        /// 当前坐标经纬度，逗号分隔
        /// </summary>
        [XmlElement("cur_lbs_poi")]
        public string CurLbsPoi { get; set; }

        /// <summary>
        /// 卡片id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 请求来源，默认传H5，H5表示详情页，返回明细数据；CUBE表示卡片，返回缩略数据
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
