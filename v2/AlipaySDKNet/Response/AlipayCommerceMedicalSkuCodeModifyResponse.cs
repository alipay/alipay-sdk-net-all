using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalSkuCodeModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalSkuCodeModifyResponse : AopResponse
    {
        /// <summary>
        /// sku信息更新失败列表，包含skuCode和失败提示信息
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("sku_code_update_fail_info_d_t_o")]
        public List<SkuCodeUpdateFailInfoDTO> FailList { get; set; }

        /// <summary>
        /// sku信息更新成功列表，包含skuCode
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("sku_code_update_success_info_d_t_o")]
        public List<SkuCodeUpdateSuccessInfoDTO> SuccList { get; set; }
    }
}
