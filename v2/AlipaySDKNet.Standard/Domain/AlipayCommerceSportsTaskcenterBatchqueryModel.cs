using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsTaskcenterBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsTaskcenterBatchqueryModel : AopObject
    {
        /// <summary>
        /// SPORTS_CENTER(文体中心), YAYUN_GAME(亚运一站通), PATH_CENTER(路线中心), RIGHTS_CENTER(权益中心), ANT_SPORTS(支付宝运动)
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 任务分组ID
        /// </summary>
        [XmlElement("task_group_id")]
        public string TaskGroupId { get; set; }

        /// <summary>
        /// 任务ID集合，可为空。 当taskGroupId不为空时,会根据taskGroupId查任务集合； 当taskGroupId为空时,会根据taskIdList查任务集合。
        /// </summary>
        [XmlArray("task_id_list")]
        [XmlArrayItem("string")]
        public List<string> TaskIdList { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
