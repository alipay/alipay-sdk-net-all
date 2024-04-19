using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncSettleReceivableConfirmResponse.
    /// </summary>
    public class AlipayBossFncSettleReceivableConfirmResponse : AopResponse
    {
        /// <summary>
        /// 应收确认结果列表
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("confirm_receivable_d_t_o")]
        public List<ConfirmReceivableDTO> ResultSet { get; set; }
    }
}
