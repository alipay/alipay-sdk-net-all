using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceUserSignQueryResponse.
    /// </summary>
    public class AlipayIserviceUserSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据信息
        /// </summary>
        [XmlElement("data_list")]
        public SignUserInfo DataList { get; set; }

        /// <summary>
        /// 数据总数量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
