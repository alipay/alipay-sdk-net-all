using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspBusinessNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspBusinessNotifyModel : AopObject
    {
        /// <summary>
        /// 用于幂等操作，不存则平台自动生成，幂等失效。
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务信息列表
        /// </summary>
        [XmlArray("business_list")]
        [XmlArrayItem("business_info_request")]
        public List<BusinessInfoRequest> BusinessList { get; set; }

        /// <summary>
        /// ISV的PID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 人员标签，如酒店住客:guest
        /// </summary>
        [XmlElement("label_out_no")]
        public string LabelOutNo { get; set; }

        /// <summary>
        /// 对象类型，详见对象定义
        /// </summary>
        [XmlElement("notify_event_param")]
        public NotifyEventParam NotifyEventParam { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("org_out_id")]
        public string OrgOutId { get; set; }

        /// <summary>
        /// 场景码，用于区别不同的业务场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 用户唯一标识
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
