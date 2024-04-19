using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceOpeneventAppdataBatchqueryResponse.
    /// </summary>
    public class AlipayEcoCityserviceOpeneventAppdataBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 符合查询条件的数据的总条数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 服务相关数据的返回值
        /// </summary>
        [XmlElement("data_detail")]
        public string DataDetail { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数据条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
