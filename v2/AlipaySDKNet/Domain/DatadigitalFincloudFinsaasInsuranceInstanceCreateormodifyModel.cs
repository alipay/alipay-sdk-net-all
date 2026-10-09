using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceInstanceCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasInsuranceInstanceCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 指令来源渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 服务指令，包括停服、恢复、释放等指令，每个渠道的指令标记不一样
        /// </summary>
        [XmlElement("command")]
        public string Command { get; set; }

        /// <summary>
        /// 开通产品的外部产品码
        /// </summary>
        [XmlElement("outer_goods_id")]
        public string OuterGoodsId { get; set; }

        /// <summary>
        /// 外部系统的实例id
        /// </summary>
        [XmlElement("outer_instance_id")]
        public string OuterInstanceId { get; set; }

        /// <summary>
        /// 外部系统租户信息
        /// </summary>
        [XmlElement("outer_tenant")]
        public string OuterTenant { get; set; }

        /// <summary>
        /// 外部系统的租户id
        /// </summary>
        [XmlElement("outer_tenant_id")]
        public string OuterTenantId { get; set; }
    }
}
