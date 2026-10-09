using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTimescardUselogBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTimescardUselogBatchqueryModel : AopObject
    {
        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 记录结束时间
        /// </summary>
        [XmlElement("log_time_end")]
        public string LogTimeEnd { get; set; }

        /// <summary>
        /// 记录开始时间
        /// </summary>
        [XmlElement("log_time_start")]
        public string LogTimeStart { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 分页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页size
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
