using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdMateriallibraryQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdMateriallibraryQueryResponse : AopResponse
    {
        /// <summary>
        /// 素材列表值
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("ad_material_detail")]
        public List<AdMaterialDetail> DataList { get; set; }

        /// <summary>
        /// 返回搜索出的素材总个数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
