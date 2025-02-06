using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemstatusByidModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemstatusByidModifyResponse : AopResponse
    {
        /// <summary>
        /// 上下架操作执行失败记录
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("item_id_status_fail_info")]
        public List<ItemIdStatusFailInfo> FailList { get; set; }

        /// <summary>
        /// 上下架操作执行成功记录
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("item_id_status_success_info")]
        public List<ItemIdStatusSuccessInfo> SuccList { get; set; }
    }
}
