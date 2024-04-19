using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeBindedminiappBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeBindedminiappBatchqueryModel : AopObject
    {
        /// <summary>
        /// 移动应用ID，必填
        /// </summary>
        [XmlElement("mobile_app_id")]
        public string MobileAppId { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 单页查询数量，最大不超过100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
