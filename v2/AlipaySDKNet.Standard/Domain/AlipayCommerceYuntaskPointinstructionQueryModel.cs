using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskPointinstructionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskPointinstructionQueryModel : AopObject
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
        /// 积分流水id，导购员每次完成一次任务会得到一个积分流水id，在查询积分流水列表时，会对应一个积分流水id
        /// </summary>
        [XmlElement("instruction_id")]
        public string InstructionId { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页面大小，单位个
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 任务id，导购员从任务列表点击某个任务进行积分查询时，这里传递的就是当前任务的id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
