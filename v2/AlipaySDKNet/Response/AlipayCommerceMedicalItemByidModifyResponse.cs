using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemByidModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemByidModifyResponse : AopResponse
    {
        /// <summary>
        /// 失败信息
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("item_update_by_id_fail_d_t_o")]
        public List<ItemUpdateByIdFailDTO> FailList { get; set; }

        /// <summary>
        /// 成功信息
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("item_update_by_id_success_d_t_o")]
        public List<ItemUpdateByIdSuccessDTO> SuccList { get; set; }
    }
}
