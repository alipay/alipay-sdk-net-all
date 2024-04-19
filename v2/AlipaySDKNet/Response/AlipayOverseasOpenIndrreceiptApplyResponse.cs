using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenIndrreceiptApplyResponse.
    /// </summary>
    public class AlipayOverseasOpenIndrreceiptApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请结果列表
        /// </summary>
        [XmlArray("apply_result_list")]
        [XmlArrayItem("indr_i_s_v_receipt_apply_result_d_t_o")]
        public List<IndrISVReceiptApplyResultDTO> ApplyResultList { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("result")]
        public IndrISVResult Result { get; set; }
    }
}
