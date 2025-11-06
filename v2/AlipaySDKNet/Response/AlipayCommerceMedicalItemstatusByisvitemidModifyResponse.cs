using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemstatusByisvitemidModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemstatusByisvitemidModifyResponse : AopResponse
    {
        /// <summary>
        /// 失败信息
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("isv_item_id_item_status_fail_d_t_o")]
        public List<IsvItemIdItemStatusFailDTO> FailList { get; set; }

        /// <summary>
        /// 成功信息
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("isv_item_id_item_status_success_d_t_o")]
        public List<IsvItemIdItemStatusSuccessDTO> SuccList { get; set; }
    }
}
