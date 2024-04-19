using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentInternalQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAppcontentInternalQueryModel : AopObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页条数，最大20
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 查询模式 QUERY_MINIAPP_BY_PID: 根据PID查询小程序服务，支持分页  QUERY_FUNCTION_BY_APPID: 根据APPID查询功能服务，不支持分页  QUERY_FUNCTION_BY_SERVICE_CODES: 根据服务编码批量查询功能服务，不支持分页
        /// </summary>
        [XmlElement("query_mode")]
        public string QueryMode { get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [XmlElement("ref_app_id")]
        public string RefAppId { get; set; }

        /// <summary>
        /// 请求方系统名称
        /// </summary>
        [XmlElement("request_system")]
        public string RequestSystem { get; set; }

        /// <summary>
        /// 服务编码列表，单次最多10个
        /// </summary>
        [XmlArray("service_code_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceCodeList { get; set; }
    }
}
