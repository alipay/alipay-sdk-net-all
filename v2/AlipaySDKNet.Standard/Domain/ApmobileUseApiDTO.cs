using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileUseApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileUseApiDTO : AopObject
    {
        /// <summary>
        /// 具体api的调用次数
        /// </summary>
        [XmlElement("api_used_num")]
        public long ApiUsedNum { get; set; }

        /// <summary>
        /// 使用apilist
        /// </summary>
        [XmlArray("app_used_api_dto_list")]
        [XmlArrayItem("apmobile_api_detail_d_t_o")]
        public List<ApmobileApiDetailDTO> AppUsedApiDtoList { get; set; }

        /// <summary>
        /// api名称
        /// </summary>
        [XmlElement("sdk_api_name")]
        public string SdkApiName { get; set; }
    }
}
