using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPageprincipalQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPageprincipalQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果数据列表，当无数据时，查询数据为空
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("ad_account_principal_info_response")]
        public List<AdAccountPrincipalInfoResponse> DataList { get; set; }

        /// <summary>
        /// 分页查询的记录总条数，单位：条
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
