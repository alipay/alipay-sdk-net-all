using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItempromoactivityListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItempromoactivityListQueryModel : AopObject
    {
        /// <summary>
        /// 页号
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页最多显示多少
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 营销活动类型
        /// </summary>
        [XmlElement("promotion_type")]
        public string PromotionType { get; set; }
    }
}
