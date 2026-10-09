using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAuthRecordByinviterQueryResponse.
    /// </summary>
    public class AlipayUserAuthRecordByinviterQueryResponse : AopResponse
    {
        /// <summary>
        /// 获取签名后的业务数据
        /// </summary>
        [XmlElement("orderStr")]
        public string OrderStr { get; set; }

        /// <summary>
        /// 邀请单查询结果
        /// </summary>
        [XmlElement("search_res")]
        public SearchDetailsByInviterRes SearchRes { get; set; }
    }
}
