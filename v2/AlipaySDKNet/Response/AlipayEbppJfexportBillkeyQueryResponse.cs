using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfexportBillkeyQueryResponse.
    /// </summary>
    public class AlipayEbppJfexportBillkeyQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的户号信息列表
        /// </summary>
        [XmlArray("billkey_list")]
        [XmlArrayItem("export_billkey")]
        public List<ExportBillkey> BillkeyList { get; set; }
    }
}
