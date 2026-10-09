using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudSupportModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCloudSupportModifyModel : AopObject
    {
        /// <summary>
        /// 要变更云服务状态的小程序应用id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 操作类型 open:开通 close:关闭
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 云服务类型 CLOUD_BASIS:云开发 CLOUD_RUN:云托管
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
