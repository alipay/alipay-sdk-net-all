using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskSupervisortaskSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskSupervisortaskSubmitModel : AopObject
    {
        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone_num")]
        public string PhoneNum { get; set; }

        /// <summary>
        /// 巡店图片url
        /// </summary>
        [XmlArray("pic_url")]
        [XmlArrayItem("string")]
        public List<string> PicUrl { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 督导员id
        /// </summary>
        [XmlElement("supervisor_id")]
        public string SupervisorId { get; set; }

        /// <summary>
        /// 任务实例id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }
    }
}
