using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerLiferecordBatchqueryResponse.
    /// </summary>
    public class ZhimaCustomerLiferecordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 生活记录详情列表
        /// </summary>
        [XmlArray("promise_details")]
        [XmlArrayItem("promise_detail")]
        public List<PromiseDetail> PromiseDetails { get; set; }

        /// <summary>
        /// 响应码
        /// </summary>
        [XmlElement("res_code")]
        public string ResCode { get; set; }

        /// <summary>
        /// 响应码编号
        /// </summary>
        [XmlElement("sub_code_number")]
        public long SubCodeNumber { get; set; }

        /// <summary>
        /// 响应说明
        /// </summary>
        [XmlElement("sub_message")]
        public string SubMessage { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("sub_success")]
        public bool SubSuccess { get; set; }
    }
}
