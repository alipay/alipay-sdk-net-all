using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommonBillkeyQueryResponse.
    /// </summary>
    public class AlipayEbppCommonBillkeyQueryResponse : AopResponse
    {
        /// <summary>
        /// 户号列表
        /// </summary>
        [XmlArray("bill_key_list")]
        [XmlArrayItem("ebpp_bill_key")]
        public List<EbppBillKey> BillKeyList { get; set; }
    }
}
