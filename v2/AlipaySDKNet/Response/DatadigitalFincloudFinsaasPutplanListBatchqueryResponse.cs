using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanListBatchqueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasPutplanListBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 列表查询结果集
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("channel_put_plan_d_t_o")]
        public List<ChannelPutPlanDTO> List { get; set; }

        /// <summary>
        /// 分页查询数据总量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
