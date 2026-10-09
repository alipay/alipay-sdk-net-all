using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWaterUsertaskdetailBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWaterUsertaskdetailBatchqueryModel : AopObject
    {
        /// <summary>
        /// 参与任务时间结束
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商家外部单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 进度上报门店名称
        /// </summary>
        [XmlElement("send_shop_name")]
        public string SendShopName { get; set; }

        /// <summary>
        /// 参与任务时间开始
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("uid_open_id")]
        public string UidOpenId { get; set; }

        /// <summary>
        /// 用户任务扣款状态
        /// </summary>
        [XmlElement("user_task_pay_status")]
        public string UserTaskPayStatus { get; set; }

        /// <summary>
        /// 用户任务状态
        /// </summary>
        [XmlElement("user_task_status")]
        public string UserTaskStatus { get; set; }
    }
}
