using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileSdkDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileSdkDTO : AopObject
    {
        /// <summary>
        /// 隐私api调用次数
        /// </summary>
        [XmlElement("api_used_num")]
        public long ApiUsedNum { get; set; }

        /// <summary>
        /// 端权限检测报告-sdk使用敏感信息分析实体
        /// </summary>
        [XmlElement("sdk_api_used_diff_by_api_list")]
        public ApmobileApiDetailDiffByApiNameDTO SdkApiUsedDiffByApiList { get; set; }

        /// <summary>
        /// SDK名称
        /// </summary>
        [XmlElement("sdk_name")]
        public string SdkName { get; set; }

        /// <summary>
        /// SDK描述
        /// </summary>
        [XmlElement("sdk_summary")]
        public string SdkSummary { get; set; }

        /// <summary>
        /// 端权限检测报告-SDK调用权限DTO
        /// </summary>
        [XmlArray("sdk_used_list")]
        [XmlArrayItem("apmobile_sdk_used_d_t_o")]
        public List<ApmobileSdkUsedDTO> SdkUsedList { get; set; }
    }
}
