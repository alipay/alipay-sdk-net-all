using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemstatusByskucodeModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemstatusByskucodeModifyResponse : AopResponse
    {
        /// <summary>
        /// 上下架操作失败信息列表
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("sku_code_item_status_fail_d_t_o")]
        public List<SkuCodeItemStatusFailDTO> FailList { get; set; }

        /// <summary>
        /// 上下架操作成功信息列表
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("sku_code_item_status_success_d_t_o")]
        public List<SkuCodeItemStatusSuccessDTO> SuccList { get; set; }
    }
}
