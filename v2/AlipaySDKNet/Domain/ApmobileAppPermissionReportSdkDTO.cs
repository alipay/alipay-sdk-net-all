using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppPermissionReportSdkDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppPermissionReportSdkDTO : AopObject
    {
        /// <summary>
        /// 集成SDK调用信息和权限详情
        /// </summary>
        [XmlArray("sdk_list")]
        [XmlArrayItem("apmobile_sdk_d_t_o")]
        public List<ApmobileSdkDTO> SdkList { get; set; }

        /// <summary>
        /// 所调用的SDK总数
        /// </summary>
        [XmlElement("sdk_sum")]
        public long SdkSum { get; set; }

        /// <summary>
        /// 使用权限的SDK数量
        /// </summary>
        [XmlElement("sdk_used")]
        public long SdkUsed { get; set; }
    }
}
