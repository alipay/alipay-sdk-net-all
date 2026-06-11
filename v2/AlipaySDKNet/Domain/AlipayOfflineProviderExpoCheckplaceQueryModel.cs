using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoCheckplaceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoCheckplaceQueryModel : AopObject
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 页码，从1开始，默认1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小，最大50，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
