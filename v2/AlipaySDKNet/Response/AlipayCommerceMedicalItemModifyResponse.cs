using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemModifyResponse : AopResponse
    {
        /// <summary>
        /// 失败信息
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("item_update_fail_info_d_t_o")]
        public List<ItemUpdateFailInfoDTO> FailList { get; set; }

        /// <summary>
        /// 成功信息
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("item_update_success_info_d_t_o")]
        public List<ItemUpdateSuccessInfoDTO> SuccList { get; set; }
    }
}
