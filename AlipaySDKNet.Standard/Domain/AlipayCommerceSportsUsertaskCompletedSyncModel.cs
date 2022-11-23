using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsUsertaskCompletedSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsUsertaskCompletedSyncModel : AopObject
    {
        /// <summary>
        /// 非必填,用户在支付宝APP或服务商小程序选择的城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 用户完成任务的北京时间。 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("completed_time")]
        public string CompletedTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 服务商自己的业务号。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 任务ID，由支付宝前期分配给服务商
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
