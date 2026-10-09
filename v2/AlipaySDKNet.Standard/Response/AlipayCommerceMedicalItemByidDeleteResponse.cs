using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemByidDeleteResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemByidDeleteResponse : AopResponse
    {
        /// <summary>
        /// 批量删除商品, 执行失败信息-ById
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("item_batch_delete_by_id_fail_info_d_t_o")]
        public List<ItemBatchDeleteByIdFailInfoDTO> FailList { get; set; }

        /// <summary>
        /// 批量删除商品, 执行成功信息-ById
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("item_batch_delete_by_id_success_info_d_t_o")]
        public List<ItemBatchDeleteByIdSuccessInfoDTO> SuccList { get; set; }
    }
}
