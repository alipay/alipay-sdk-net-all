using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceViewcallbackQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceViewcallbackQueryModel : AopObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务视图元数据ID
        /// </summary>
        [XmlElement("service_view_meta_id")]
        public string ServiceViewMetaId { get; set; }
    }
}
