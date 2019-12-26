using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserLogonidMaskedQueryResponse.
    /// </summary>
    public class AlipayUserLogonidMaskedQueryResponse : AopResponse
    {
        /// <summary>
        /// 脱敏后的登录名视图。【注意】如果入参中某一userId不存在，返回的视图列表中将不包含该userId对应视图。（举例：入参里10个userId，其中1个userId不存在，则出参列表里有9个视图）
        /// </summary>
        [XmlArray("logon_id_views")]
        [XmlArrayItem("masked_logon_id_view")]
        public List<MaskedLogonIdView> LogonIdViews { get; set; }
    }
}
