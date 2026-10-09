using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandApprecommendAvailableQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandApprecommendAvailableQueryModel : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 单页行数，不能超过100行
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
