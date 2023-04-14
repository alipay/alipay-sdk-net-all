using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleDataDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SettleDataDetail : AopObject
    {
        /// <summary>
        /// 结算指标详情数据
        /// </summary>
        [XmlElement("data_detail")]
        public string DataDetail { get; set; }

        /// <summary>
        /// openid
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
