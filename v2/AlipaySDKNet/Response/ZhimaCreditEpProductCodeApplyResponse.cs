using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpProductCodeApplyResponse.
    /// </summary>
    public class ZhimaCreditEpProductCodeApplyResponse : AopResponse
    {
        /// <summary>
        /// 批次号,本次申请单据号与商户所传org_biz_no一一对应
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 申码结果信息:  code_id  二维码唯一标识id;  code_url 二维码url地址
        /// </summary>
        [XmlArray("code_list")]
        [XmlArrayItem("code_res_info")]
        public List<CodeResInfo> CodeList { get; set; }
    }
}
