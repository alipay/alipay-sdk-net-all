using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtHrhealthEntryUserBatchqueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtHrhealthEntryUserBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 候选人信息列表，根据主数据中最近要入职的候选人数据加工获取，数组数据，供应商拿到参数后进行初始化，返回值为空时代表无最近入职的候选人
        /// </summary>
        [XmlArray("entry_person_list")]
        [XmlArrayItem("entry_health_person_info")]
        public List<EntryHealthPersonInfo> EntryPersonList { get; set; }
    }
}
