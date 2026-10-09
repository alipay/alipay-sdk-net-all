using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativePictaskresultQueryResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApecreativePictaskresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 素材生产结果
        /// </summary>
        [XmlElement("material_result_info_list")]
        public MaterialResultInfo MaterialResultInfoList { get; set; }

        /// <summary>
        /// 素材产生结果
        /// </summary>
        [XmlArray("material_result_list")]
        [XmlArrayItem("material_result_info")]
        public List<MaterialResultInfo> MaterialResultList { get; set; }
    }
}
