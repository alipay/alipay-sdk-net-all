using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalFmBindlistQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalFmBindlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 主账户绑定的亲情账户列表
        /// </summary>
        [XmlArray("bind_list")]
        [XmlArrayItem("fm_bind_fm_v_o")]
        public List<FmBindFmVO> BindList { get; set; }
    }
}
