using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelIntlBrandSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelIntlBrandSyncModel : AopObject
    {
        /// <summary>
        /// 品牌信息
        /// </summary>
        [XmlElement("brand_info")]
        public IntlBrandInfo BrandInfo { get; set; }

        /// <summary>
        /// 外部信息列表
        /// </summary>
        [XmlArray("external_list")]
        [XmlArrayItem("external_info")]
        public List<ExternalInfo> ExternalList { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
