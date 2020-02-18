using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionConditionBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionConditionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序版本信息
        /// </summary>
        [XmlArray("mini_version_base_info_list")]
        [XmlArrayItem("mini_version_base_info")]
        public List<MiniVersionBaseInfo> MiniVersionBaseInfoList { get; set; }
    }
}
