using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdUserbalanceOnlineResponse.
    /// </summary>
    public class AlipayDataDataserviceAdUserbalanceOnlineResponse : AopResponse
    {
        /// <summary>
        /// 操作成功投放账户id列表
        /// </summary>
        [XmlArray("success_user_id_list")]
        [XmlArrayItem("number")]
        public List<long> SuccessUserIdList { get; set; }
    }
}
