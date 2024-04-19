using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCreditProductSignResponse.
    /// </summary>
    public class AlipayTradeCreditProductSignResponse : AopResponse
    {
        /// <summary>
        /// 合约批次号；成功场景下才会返回
        /// </summary>
        [XmlElement("contract_batch_no")]
        public string ContractBatchNo { get; set; }

        /// <summary>
        /// 合约号；成功场景下才会返回
        /// </summary>
        [XmlElement("contract_no_list")]
        public string ContractNoList { get; set; }

        /// <summary>
        /// 第三方错误上下文；只有失败情况下才会返回
        /// </summary>
        [XmlElement("third_error_context")]
        public ThirdErrorContext ThirdErrorContext { get; set; }
    }
}
