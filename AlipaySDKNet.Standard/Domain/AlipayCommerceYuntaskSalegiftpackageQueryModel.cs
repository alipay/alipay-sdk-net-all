using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskSalegiftpackageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskSalegiftpackageQueryModel : AopObject
    {
        /// <summary>
        /// 商家pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 分页页码，默认是1
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页面大小，默认是10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
