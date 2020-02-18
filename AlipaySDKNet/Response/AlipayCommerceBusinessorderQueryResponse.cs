using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceBusinessorderQueryResponse.
    /// </summary>
    public class AlipayCommerceBusinessorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 分页查询的办事记录详情列表，没条记录包含isvAppId(isv的appid)、subject(一条办事记录的摘要),status(一条办事记录的状态),recordTime(一条办事记录创建的时间)
        /// </summary>
        [XmlElement("record_detail")]
        public string RecordDetail { get; set; }
    }
}
