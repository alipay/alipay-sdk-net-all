using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotManufacturerSnQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotManufacturerSnQueryModel : AopObject
    {
        /// <summary>
        /// 用于查询设备url信息
        /// </summary>
        [XmlArray("tag_sn_info_list_request")]
        [XmlArrayItem("tag_sn_info_list_request")]
        public List<TagSnInfoListRequest> TagSnInfoListRequest { get; set; }
    }
}
