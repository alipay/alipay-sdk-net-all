using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferenceBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfrtcVideoconferenceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 用户进入信息
        /// </summary>
        [XmlArray("member_enter_infos")]
        [XmlArrayItem("member_enter_info")]
        public List<MemberEnterInfo> MemberEnterInfos { get; set; }
    }
}
