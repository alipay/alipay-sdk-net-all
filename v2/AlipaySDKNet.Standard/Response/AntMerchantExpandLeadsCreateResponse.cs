using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandLeadsCreateResponse.
    /// </summary>
    public class AntMerchantExpandLeadsCreateResponse : AopResponse
    {
        /// <summary>
        /// 提报leads返回的错误,或者不通过的信息提示,根据提示信息可联系相关对接人员解决
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// leadsId信息,可以通过该ID查询相关信息,业务主键,如果失败则不一定有leadsId
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 是否需要通过风控审核leads信息,如果需要审核的话,则是异步等待消息通知
        /// </summary>
        [XmlElement("need_audit")]
        public bool NeedAudit { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// leads提报是否通过,未通过可以通过fail_reason查看具体失败原因,如果是repeat_leads_id有值,则代表leads_id重复
        /// </summary>
        [XmlElement("pass")]
        public bool Pass { get; set; }

        /// <summary>
        /// 重复返回的leadsId信息
        /// </summary>
        [XmlElement("repeat_leads_id")]
        public string RepeatLeadsId { get; set; }
    }
}
