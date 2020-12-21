using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOperationAppserviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOperationAppserviceQueryModel : AopObject
    {
        /// <summary>
        /// 要查询的子服务所属的小程序应用id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 查询应用子服务页数，默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 查询应用子服务每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 子服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }
    }
}
