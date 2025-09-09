using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemstatusBycodeModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemstatusBycodeModifyResponse : AopResponse
    {
        /// <summary>
        /// 上下架操作执行失败信息
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("item_code_status_fail_info")]
        public List<ItemCodeStatusFailInfo> FailList { get; set; }

        /// <summary>
        /// 上下架执行成功的记录
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("item_code_status_success_info")]
        public List<ItemCodeStatusSuccessInfo> SuccList { get; set; }
    }
}
