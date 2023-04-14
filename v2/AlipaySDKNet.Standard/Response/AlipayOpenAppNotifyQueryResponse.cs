using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppNotifyQueryResponse.
    /// </summary>
    public class AlipayOpenAppNotifyQueryResponse : AopResponse
    {
        /// <summary>
        /// notify_info_list+是+用于返回用户的信息+调接口返回得到
        /// </summary>
        [XmlArray("notify_info_list")]
        [XmlArrayItem("notify_info")]
        public List<NotifyInfo> NotifyInfoList { get; set; }
    }
}
