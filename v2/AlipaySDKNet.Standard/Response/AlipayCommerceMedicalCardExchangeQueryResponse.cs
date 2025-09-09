using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCardExchangeQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCardExchangeQueryResponse : AopResponse
    {
        /// <summary>
        /// 开通兑换详情
        /// </summary>
        [XmlArray("open_info_list")]
        [XmlArrayItem("open_info_d_t_o")]
        public List<OpenInfoDTO> OpenInfoList { get; set; }

        /// <summary>
        /// 1-已开通   2-未开通
        /// </summary>
        [XmlElement("open_status")]
        public long OpenStatus { get; set; }

        /// <summary>
        /// 时间戳，毫秒
        /// </summary>
        [XmlElement("open_time")]
        public long OpenTime { get; set; }
    }
}
