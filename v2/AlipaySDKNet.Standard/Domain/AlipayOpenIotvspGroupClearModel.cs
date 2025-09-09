using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspGroupClearModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspGroupClearModel : AopObject
    {
        /// <summary>
        /// 业务id，由调用方生成的唯一业务流水，原则上不可重复
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 机构外标
        /// </summary>
        [XmlElement("org_out_id")]
        public string OrgOutId { get; set; }
    }
}
