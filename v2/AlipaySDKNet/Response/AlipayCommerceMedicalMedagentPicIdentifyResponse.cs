using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentPicIdentifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedagentPicIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 图片内容坐标信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("coordinate_info")]
        public List<CoordinateInfo> Data { get; set; }
    }
}
