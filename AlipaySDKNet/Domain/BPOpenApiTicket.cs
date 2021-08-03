using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BPOpenApiTicket Data Structure.
    /// </summary>
    [Serializable]
    public class BPOpenApiTicket : AopObject
    {
        /// <summary>
        /// 附件
        /// </summary>
        [XmlElement("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// 来自于哪个系统
        /// </summary>
        [XmlElement("biz_app")]
        public string BizApp { get; set; }

        /// <summary>
        /// 业务ID, 若来自fcprocess系统，则为pcs_process_instance_id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务上下文
        /// </summary>
        [XmlElement("business_context")]
        public string BusinessContext { get; set; }

        /// <summary>
        /// 变更版本号
        /// </summary>
        [XmlElement("change_version")]
        public long ChangeVersion { get; set; }

        /// <summary>
        /// 配置ID
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 创建人用户域名
        /// </summary>
        [XmlElement("create_operator")]
        public string CreateOperator { get; set; }

        /// <summary>
        /// 创建者名称
        /// </summary>
        [XmlElement("create_operator_name")]
        public string CreateOperatorName { get; set; }

        /// <summary>
        /// 工单处理链接地址
        /// </summary>
        [XmlElement("deal_url")]
        public string DealUrl { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 工单内嵌详情地址
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 配置显示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 域ID
        /// </summary>
        [XmlElement("domain_id")]
        public string DomainId { get; set; }

        /// <summary>
        /// 完结时间间隔（毫秒）
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_property")]
        public string ExtProperty { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 完结时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 幂等ID
        /// </summary>
        [XmlElement("idempotent_id")]
        public string IdempotentId { get; set; }

        /// <summary>
        /// 业务属性列表, 列表长度为10
        /// </summary>
        [XmlArray("info_values")]
        [XmlArrayItem("string")]
        public List<string> InfoValues { get; set; }

        /// <summary>
        /// 流程租户ID
        /// </summary>
        [XmlElement("instance_tnt_inst_id")]
        public string InstanceTntInstId { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 上一步操作
        /// </summary>
        [XmlElement("last_operate")]
        public string LastOperate { get; set; }

        /// <summary>
        /// 紧急程度
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 修改人用户域名
        /// </summary>
        [XmlElement("modify_operator")]
        public string ModifyOperator { get; set; }

        /// <summary>
        /// 修改者姓名
        /// </summary>
        [XmlElement("modify_operator_name")]
        public string ModifyOperatorName { get; set; }

        /// <summary>
        /// 工单名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父工单id
        /// </summary>
        [XmlElement("parent_ticket_id")]
        public long ParentTicketId { get; set; }

        /// <summary>
        /// 关联的某个版本的流程id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 预期结束时间
        /// </summary>
        [XmlElement("should_finish_time")]
        public string ShouldFinishTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 同步到的第三方平台
        /// </summary>
        [XmlElement("third_party")]
        public string ThirdParty { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 无线端工单详情地址
        /// </summary>
        [XmlElement("wireless_detail_url")]
        public string WirelessDetailUrl { get; set; }
    }
}
