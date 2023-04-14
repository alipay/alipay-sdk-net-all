using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthQuickhireSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthQuickhireSyncModel : AopObject
    {
        /// <summary>
        /// 岗位唯一id
        /// </summary>
        [XmlElement("recruit_code_id")]
        public string RecruitCodeId { get; set; }

        /// <summary>
        /// 信用服务，由芝麻信用运营分配，请联系业务对接人配置，固定写死即可
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 岗位上线状态，0 = 审核中，1 = 已上线， 2 = 拒绝，3 = 下线
        /// </summary>
        [XmlElement("sync_status")]
        public string SyncStatus { get; set; }
    }
}
