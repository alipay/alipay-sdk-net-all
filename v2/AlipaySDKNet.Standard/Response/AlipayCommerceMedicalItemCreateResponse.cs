using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemCreateResponse : AopResponse
    {
        /// <summary>
        /// 失败记录
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("item_create_fail_info_d_t_o")]
        public List<ItemCreateFailInfoDTO> FailList { get; set; }

        /// <summary>
        /// 成功记录
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("item_create_success_info_d_t_o")]
        public List<ItemCreateSuccessInfoDTO> SuccList { get; set; }
    }
}
