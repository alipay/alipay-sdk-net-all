using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdAltechlegalDepositQueryResponse.
    /// </summary>
    public class AlipaySecurityProdAltechlegalDepositQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("deposit_file_list")]
        [XmlArrayItem("deposit_file_list")]
        public List<DepositFileList> DepositFileList { get; set; }
    }
}
