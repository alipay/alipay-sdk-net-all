using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalSkuModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalSkuModifyResponse : AopResponse
    {
        /// <summary>
        /// sku信息更新失败列表，包含店内码，错误提示信息
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("sku_update_fail_info_d_t_o")]
        public List<SkuUpdateFailInfoDTO> FailList { get; set; }

        /// <summary>
        /// sku信息更新成功列表，包含店内码
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("sku_update_success_info_d_t_o")]
        public List<SkuUpdateSuccessInfoDTO> SuccList { get; set; }
    }
}
