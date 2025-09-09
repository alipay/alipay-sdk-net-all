using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemBatchDeleteResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemBatchDeleteResponse : AopResponse
    {
        /// <summary>
        /// 批量删除商品, 执行失败信息
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("item_update_fail_info_d_t_o")]
        public List<ItemUpdateFailInfoDTO> FailList { get; set; }

        /// <summary>
        /// 批量删除商品, 执行成功信息
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("item_batch_delete_success_info_d_t_o")]
        public List<ItemBatchDeleteSuccessInfoDTO> SuccList { get; set; }
    }
}
