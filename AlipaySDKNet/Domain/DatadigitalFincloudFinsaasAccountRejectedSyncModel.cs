using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasAccountRejectedSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasAccountRejectedSyncModel : AopObject
    {
        /// <summary>
        /// 标识用户活动数据的唯一id
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 拒绝的时间
        /// </summary>
        [XmlElement("gmt_rejected")]
        public string GmtRejected { get; set; }
    }
}
