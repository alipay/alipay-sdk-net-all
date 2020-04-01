using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlawOrderhitstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlawOrderhitstatusQueryModel : AopObject
    {
        /// <summary>
        /// 请求来源系统英文名称
        /// </summary>
        [XmlElement("request_app_name")]
        public string RequestAppName { get; set; }

        /// <summary>
        /// 关联业务数据编号
        /// </summary>
        [XmlElement("request_biz_num")]
        public string RequestBizNum { get; set; }

        /// <summary>
        /// 请求token
        /// </summary>
        [XmlElement("request_hash_value")]
        public string RequestHashValue { get; set; }

        /// <summary>
        /// 请求时间戳（请求时间的毫秒值）
        /// </summary>
        [XmlElement("request_time_stamp")]
        public string RequestTimeStamp { get; set; }
    }
}
