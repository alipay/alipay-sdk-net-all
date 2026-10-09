using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasEbankConsultResponse.
    /// </summary>
    public class AlipayTradeSaasEbankConsultResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("bank_code_list")]
        [XmlArrayItem("string")]
        public List<string> BankCodeList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("inst_id_list")]
        [XmlArrayItem("string")]
        public List<string> InstIdList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("inst_info_list")]
        [XmlArrayItem("saas_ebank_inst_info")]
        public List<SaasEbankInstInfo> InstInfoList { get; set; }
    }
}
