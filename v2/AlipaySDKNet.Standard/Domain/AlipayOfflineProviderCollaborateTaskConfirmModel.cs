using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateTaskConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCollaborateTaskConfirmModel : AopObject
    {
        /// <summary>
        /// 当前操作在业务系统实际发生的时间。 匹配格式yyyy-MM-dd HH:mm:ss的date类型
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 商家意图确认结果；当反馈商家有意向 HAS,接口将返回详细作业信息，任务状态推进到已确认；当反馈商家无意向 NOT_HAS,接口不返回详细作业信息，任务状态推进到无法完成，当反馈商家无法联系，接口将根据业务规则判断是否返回详细作业信息，任务状态不推进
        /// </summary>
        [XmlElement("confirm_result")]
        public string ConfirmResult { get; set; }

        /// <summary>
        /// 外部系统对应操作流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 拉取任务时获得的任务号
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }
    }
}
