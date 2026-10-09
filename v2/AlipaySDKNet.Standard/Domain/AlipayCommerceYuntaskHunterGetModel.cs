using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskHunterGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskHunterGetModel : AopObject
    {
        /// <summary>
        /// 导购员id
        /// </summary>
        [XmlElement("hunter_id")]
        public string HunterId { get; set; }

        /// <summary>
        /// 导购员id
        /// </summary>
        [XmlElement("hunter_open_id")]
        public string HunterOpenId { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务模板id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
