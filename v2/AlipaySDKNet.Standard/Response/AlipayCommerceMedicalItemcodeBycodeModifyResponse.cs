using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemcodeBycodeModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemcodeBycodeModifyResponse : AopResponse
    {
        /// <summary>
        /// 失败列表
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("item_updated_by_code_fail_v_o")]
        public List<ItemUpdatedByCodeFailVO> FailList { get; set; }

        /// <summary>
        /// 成功对象列表
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("update_code_by_code_success_info")]
        public List<UpdateCodeByCodeSuccessInfo> SuccList { get; set; }
    }
}
