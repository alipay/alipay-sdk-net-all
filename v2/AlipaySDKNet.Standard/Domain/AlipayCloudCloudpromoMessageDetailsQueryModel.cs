using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageDetailsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMessageDetailsQueryModel : AopObject
    {
        /// <summary>
        /// 发送回执 ID，即发送流水号。
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页展示数目
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 接收短信的手机号码
        /// </summary>
        [XmlArray("phone_number")]
        [XmlArrayItem("string")]
        public List<string> PhoneNumber { get; set; }

        /// <summary>
        /// 短信发送日期，支持查询最近 30 天的记录。 格式为 yyyyMMdd，例如 20181225。
        /// </summary>
        [XmlElement("send_date")]
        public string SendDate { get; set; }
    }
}
