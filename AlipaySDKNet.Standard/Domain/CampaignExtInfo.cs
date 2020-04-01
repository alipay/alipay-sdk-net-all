using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CampaignExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CampaignExtInfo : AopObject
    {
        /// <summary>
        /// 用户不活跃间隔时间，当用户集点满足阙值且满足不活跃间隔时间后，发送召回通知
        /// </summary>
        [XmlElement("interval_time")]
        public string IntervalTime { get; set; }

        /// <summary>
        /// 集点阈值，即当用户集点进度达到阙值后才会根据间隔时间下发召回唤醒
        /// </summary>
        [XmlElement("threshold")]
        public string Threshold { get; set; }
    }
}
