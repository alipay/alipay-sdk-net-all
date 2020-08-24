using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvDsbIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvDsbIdentifyModel : AopObject
    {
        /// <summary>
        /// 蚂蚁内部单号
        /// </summary>
        [XmlElement("ant_estimate_no")]
        public string AntEstimateNo { get; set; }

        /// <summary>
        /// 外部保险单号
        /// </summary>
        [XmlElement("estimate_request_no")]
        public string EstimateRequestNo { get; set; }

        /// <summary>
        /// 定损图片信息
        /// </summary>
        [XmlArray("image_info")]
        [XmlArrayItem("dsb_image_info")]
        public List<DsbImageInfo> ImageInfo { get; set; }
    }
}
