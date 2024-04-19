using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 当前页数，不填本参数默认为 1。
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 查询结果每页记录数，最大不超过 50，不填本参数默认为 10。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
