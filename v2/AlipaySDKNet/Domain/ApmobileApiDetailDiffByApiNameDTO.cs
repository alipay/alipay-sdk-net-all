using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileApiDetailDiffByApiNameDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileApiDetailDiffByApiNameDTO : AopObject
    {
        /// <summary>
        /// 敏感信息名称
        /// </summary>
        [XmlElement("api_name")]
        public string ApiName { get; set; }

        /// <summary>
        /// 敏感信息类型
        /// </summary>
        [XmlElement("api_type")]
        public string ApiType { get; set; }

        /// <summary>
        /// 调用详情
        /// </summary>
        [XmlElement("app_used_api_dto_list")]
        public ApmobileApiDetailDTO AppUsedApiDtoList { get; set; }

        /// <summary>
        /// 调用次数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }
    }
}
