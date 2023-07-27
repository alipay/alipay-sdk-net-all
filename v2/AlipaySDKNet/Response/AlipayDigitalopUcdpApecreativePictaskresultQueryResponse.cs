using System;
using System.Xml.Serialization;
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
    }
}
