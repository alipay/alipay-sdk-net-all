using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWaterUsertaskSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWaterUsertaskSendModel : AopObject
    {
        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，商家外部单号，同时用于幂等，同一个任务id，一个外部单号只能上报一次
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 上报所属门店名称
        /// </summary>
        [XmlElement("send_shop_name")]
        public string SendShopName { get; set; }

        /// <summary>
        /// 商户创建任务后生成的任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户参与任务生成的用户任务id
        /// </summary>
        [XmlElement("user_task_id")]
        public string UserTaskId { get; set; }
    }
}
