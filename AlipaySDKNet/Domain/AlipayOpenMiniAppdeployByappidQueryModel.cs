using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAppdeployByappidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAppdeployByappidQueryModel : AopObject
    {
        /// <summary>
        /// 端标识
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 租户标识
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 当前页，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页个数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
