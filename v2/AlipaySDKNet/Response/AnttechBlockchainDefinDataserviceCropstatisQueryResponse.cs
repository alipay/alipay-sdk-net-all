using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceCropstatisQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinDataserviceCropstatisQueryResponse : AopResponse
    {
        /// <summary>
        /// 作物统计信息
        /// </summary>
        [XmlArray("crop_statistics")]
        [XmlArrayItem("crops_statistics_info")]
        public List<CropsStatisticsInfo> CropStatistics { get; set; }
    }
}
