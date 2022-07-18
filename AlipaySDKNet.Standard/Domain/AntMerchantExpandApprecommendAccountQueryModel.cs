using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandApprecommendAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandApprecommendAccountQueryModel : AopObject
    {
        /// <summary>
        /// 已关联小程序的app_id
        /// </summary>
        [XmlElement("app_no")]
        public string AppNo { get; set; }

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
