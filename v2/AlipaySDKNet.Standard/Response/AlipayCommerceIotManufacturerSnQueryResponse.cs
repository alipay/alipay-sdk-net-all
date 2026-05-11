using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotManufacturerSnQueryResponse.
    /// </summary>
    public class AlipayCommerceIotManufacturerSnQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询的sn信息返回值
        /// </summary>
        [XmlArray("tag_url_info_list")]
        [XmlArrayItem("tag_url_info")]
        public List<TagUrlInfo> TagUrlInfoList { get; set; }
    }
}
