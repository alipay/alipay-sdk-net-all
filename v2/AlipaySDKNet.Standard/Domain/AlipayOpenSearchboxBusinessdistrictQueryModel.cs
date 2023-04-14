using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchboxBusinessdistrictQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchboxBusinessdistrictQueryModel : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 直达对应选择的官方账户应用ID
        /// </summary>
        [XmlArray("relate_appid_list")]
        [XmlArrayItem("string")]
        public List<string> RelateAppidList { get; set; }
    }
}
