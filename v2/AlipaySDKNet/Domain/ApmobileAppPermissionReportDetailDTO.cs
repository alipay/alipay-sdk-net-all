using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppPermissionReportDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppPermissionReportDetailDTO : AopObject
    {
        /// <summary>
        /// 检测详情
        /// </summary>
        [XmlArray("detect_detail_list")]
        [XmlArrayItem("apmobile_detect_detail_d_t_o")]
        public List<ApmobileDetectDetailDTO> DetectDetailList { get; set; }
    }
}
