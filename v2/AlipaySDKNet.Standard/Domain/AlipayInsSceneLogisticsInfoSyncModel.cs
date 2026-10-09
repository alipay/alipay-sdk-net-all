using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneLogisticsInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneLogisticsInfoSyncModel : AopObject
    {
        /// <summary>
        /// 业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// isv标识
        /// </summary>
        [XmlElement("isv_identity")]
        public string IsvIdentity { get; set; }

        /// <summary>
        /// 物流商的物流单号
        /// </summary>
        [XmlElement("mail_no")]
        public string MailNo { get; set; }

        /// <summary>
        /// 同步内容
        /// </summary>
        [XmlElement("sync_data")]
        public LogisticsSyncDataDTO SyncData { get; set; }

        /// <summary>
        /// 物流同步的类型
        /// </summary>
        [XmlElement("sync_type")]
        public string SyncType { get; set; }
    }
}
