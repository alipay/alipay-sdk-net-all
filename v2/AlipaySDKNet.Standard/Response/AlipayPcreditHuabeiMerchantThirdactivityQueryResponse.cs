using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantThirdactivityQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantThirdactivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动信息列表
        /// </summary>
        [XmlArray("activity_info_list")]
        [XmlArrayItem("third_activity_info")]
        public List<ThirdActivityInfo> ActivityInfoList { get; set; }
    }
}
