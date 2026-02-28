using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailFocusbenefitdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailFocusbenefitdataQueryModel : AopObject
    {
        /// <summary>
        /// 天分区
        /// </summary>
        [XmlElement("dt_list")]
        public string DtList { get; set; }

        /// <summary>
        /// 时间分区
        /// </summary>
        [XmlElement("hh_list")]
        public string HhList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
