using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbypoiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceMiniappnearbypoiQueryModel : AopObject
    {
        /// <summary>
        /// poiCode列表
        /// </summary>
        [XmlArray("poi_code_list")]
        [XmlArrayItem("string")]
        public List<string> PoiCodeList { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
