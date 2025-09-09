using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemcodeByidModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemcodeByidModifyResponse : AopResponse
    {
        /// <summary>
        /// 失败列表
        /// </summary>
        [XmlElement("fail_list")]
        public ItemUpdatedByIdFailVO FailList { get; set; }

        /// <summary>
        /// 成功列表
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("update_code_by_id_success_info")]
        public List<UpdateCodeByIdSuccessInfo> SuccList { get; set; }
    }
}
