using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceIndustrymsgAuthBatchqueryResponse.
    /// </summary>
    public class AlipayEcoCityserviceIndustrymsgAuthBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 筛选出来的在市民中心已订阅行业动帐消息的用户信息列表
        /// </summary>
        [XmlArray("certificate_info_list")]
        [XmlArrayItem("certificate_info")]
        public List<CertificateInfo> CertificateInfoList { get; set; }
    }
}
