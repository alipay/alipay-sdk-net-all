using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNotaryprocsumQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlegalchainNotaryprocsumQueryModel : AopObject
    {
        /// <summary>
        /// 法链签约业务ID，发起签约会返回对应的ID值
        /// </summary>
        [XmlElement("bas_data_id")]
        public string BasDataId { get; set; }

        /// <summary>
        /// 请求来源系统英文名称
        /// </summary>
        [XmlElement("request_app_name")]
        public string RequestAppName { get; set; }

        /// <summary>
        /// 请求时间戳（请求时间的毫秒值）
        /// </summary>
        [XmlElement("request_time_stamp")]
        public string RequestTimeStamp { get; set; }

        /// <summary>
        /// 请求token
        /// </summary>
        [XmlElement("request_token")]
        public string RequestToken { get; set; }
    }
}
